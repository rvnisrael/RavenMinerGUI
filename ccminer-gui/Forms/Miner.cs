﻿using ccminer_gui.Entities;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.Serialization;
using System.Runtime.InteropServices;


namespace ccminer_gui
{
    public partial class Miner : Form
    {
        public Miner()
        {
            InitializeComponent();

            _miner = new CCMinerInterop();
            _miner.OutputDataReceived += _miner_OutputDataReceived;
            _miner.ErrorDataReceived += _miner_ErrorDataReceived;

            timer1.Enabled = true;
            timer1.Start();

            SetupUI();
        }

        private void AddItem(string data)
        {
            Invoke((MethodInvoker)(() =>
            {
                listBox1.Items.Add(data);
                listBox1.SelectedIndex = listBox1.Items.Count - 1;
                listBox1.ClearSelected();
                if (listBox1.Items.Count > 100)
                {
                    listBox1.Items.RemoveAt(0);
                }
            }));
        }

        private void ParseReport(MinerReport report)
        {
            Invoke((MethodInvoker)(() =>
            {
                acceptedSharesLabel.Text = report.AcceptedShares.ToString();
                totalSharesLabel.Text = report.TotalShares.ToString();
                staleSharesLabel.Text = report.StaleShares.ToString();

                totalHashrateLabel.Text = report.TotalHashrate.ToString() + " MH/s";
                blockDifficultyLabel.Text = report.BlockDifficulty.ToString();
                stratumDifficultyLabel.Text = report.StratumDifficulty.ToString();
                blockLabel.Text = report.Block.ToString();
            }));
        }

        private void _miner_ErrorDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            AddItem(e.Data);
        }

        private void _miner_OutputDataReceived(object sender, System.Diagnostics.DataReceivedEventArgs e)
        {
            AddItem(e.Data);
        }

        private CCMinerInterop _miner;
        private CustomConfig _customConfig;

        private bool _isStarted = false;

        private string _path = Path.Combine(Environment.CurrentDirectory, "guiminer.conf");
        private BinaryFormatter _bin = new BinaryFormatter();
        
        private Series _hashrateSeries;
        private Series _difficultySeries;

        private Series _acceptedSeries;
        private Series _staleSeries;

        private void SetupUI()
        {
            // Set all algorithms.
            foreach (var algorithm in _miner.GetList())
            {
                algorithmBox.Items.Add(algorithm);
            }

            if (!File.Exists(_path))
            {
                var dc = new DefaultConfig();
                algorithmBox.Text = dc.Algorithm;
                intensityBox.Text = dc.Intensity;
                gpuStatsBox.Value = dc.StatsAvg;
                usernameBox.Text = dc.Username;
                passwordBox.Text = dc.Password;
                poolUrlBox.Text = dc.PoolUrl;
            }
            else
            {
                using (FileStream fs = new FileStream(_path, FileMode.Open)) //double check that...
                {
                    var dc = (CustomConfig)_bin.Deserialize(fs);
                    algorithmBox.Text = dc.Algorithm;
                    intensityBox.Text = dc.Intensity;
                    gpuStatsBox.Value = dc.StatsAvg;
                    usernameBox.Text = dc.Username;
                    passwordBox.Text = dc.Password;
                    poolUrlBox.Text = dc.PoolUrl;
                }
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            _customConfig = new CustomConfig();
            _customConfig.SetConfig(intensityBox.Text, usernameBox.Text, passwordBox.Text, poolUrlBox.Text, Convert.ToInt32(gpuStatsBox.Value), algorithmBox.Text);

            using (FileStream fs = new FileStream(_path, FileMode.Create))
            {
                _bin.Serialize(fs, _customConfig);
            }

            _isStarted = !_isStarted;

            if (!idleBox.Checked)
            {
                if (!_miner.IsRunning)
                {
                    AddItem("----------- Starting Raven Miner -----------");
                    _miner.Run(_customConfig);
                }
            }
            else
            {
                if (!_miner.IsRunning && _isStarted)
                {
                    AddItem("----------- Waiting to Start Miner for PC Idle -----------");
                }
            }

            if (_isStarted)
            {
                startButton.Text = "Stop Raven Miner";
                // Disable UI items.
                algorithmBox.Enabled = false;
                intensityBox.ReadOnly = true;
                gpuStatsBox.ReadOnly = true;
                usernameBox.ReadOnly = true;
                passwordBox.ReadOnly = true;
                poolUrlBox.ReadOnly = true;
                idleBox.Enabled = false;
            }
            else
            {
                _miner.Stop();
                _miner.ResetMinerReport();
                AddItem("----------- Stopped Miner -----------");
                startButton.Text = "Start Raven Miner";
                algorithmBox.Enabled = true;
                intensityBox.ReadOnly = false;
                gpuStatsBox.ReadOnly = false;
                usernameBox.ReadOnly = false;
                passwordBox.ReadOnly = false;
                poolUrlBox.ReadOnly = false;
                idleBox.Enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Check status.
            statusLabel.Text = (_miner.IsRunning ? "Running." : "Stopped.");

            if (idleBox.Checked && _isStarted)
            {
                if (Win32.GetIdleTime() > (2 * 60 * 1000))
                {
                    if (!_miner.IsRunning)
                    {
                        AddItem("----------- Starting Miner (Detected PC Idle) -----------");
                        _miner.Run(_customConfig);
                    }
                }
                else
                {
                    if (_miner.IsRunning)
                    {
                        _miner.Stop();
                        _miner.ResetMinerReport();
                        AddItem("----------- Stopped Miner (Detected PC Input) -----------");
                    }
                }
            }
            else if (!idleBox.Checked && _isStarted)
            {
                // Crash checker.
                if (!_miner.IsRunning)
                {
                    AddItem("----------- Starting Miner (Previous Crashed?) -----------");
                    _miner.Run(_customConfig);
                }
            }

            // No matter what, just parse the report.
            if (_isStarted)
            {
                ParseReport(_miner.GetMinerReport());
            }
        }

        private void Miner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_miner.IsRunning && _isStarted)
            {
                _isStarted = false;
                _miner.Stop();
                _miner.ResetMinerReport();
            }
        }

        private void Miner_Load(object sender, EventArgs e)
        {
            _difficultySeries  = new Series("Block Difficulty")
            {
                XValueType = ChartValueType.Time,
                ChartType = SeriesChartType.Spline,
                Color = Color.Orange,
                BorderWidth = 2,
            };

            _hashrateSeries = new Series("Hashrate (kH/s)")
            {
                XValueType = ChartValueType.Time,
                ChartType = SeriesChartType.Spline,
                Color = Color.Purple,
                BorderWidth = 2,
            };

            _difficultySeries.Points.Add(new DataPoint(DateTime.Now.ToOADate(), 0));
            _hashrateSeries.Points.Add(new DataPoint(DateTime.Now.ToOADate(), 0));

            chart1.Series.Add(_difficultySeries);
            chart1.Series.Add(_hashrateSeries);

            _acceptedSeries = new Series("Accepted Shares")
            {
                XValueType = ChartValueType.Time,
                ChartType = SeriesChartType.Line,
                Color = Color.Green,
                BorderWidth = 2,
            };

            _staleSeries = new Series("Stale Shares")
            {
                XValueType = ChartValueType.Time,
                ChartType = SeriesChartType.Line,
                Color = Color.Red,
                BorderWidth = 2,
            };

            _acceptedSeries.Points.Add(new DataPoint(DateTime.Now.ToOADate(), 0));
            _staleSeries.Points.Add(new DataPoint(DateTime.Now.ToOADate(), 0));

            chart2.Series.Add(_acceptedSeries);
            chart2.Series.Add(_staleSeries);

            chartTimer.Tick += ChartTimer_Tick;
            chartTimer.Interval = 5000;

            chartTimer.Start();
        }

        private void ChartTimer_Tick(object sender, EventArgs e)
        {
            var report = _miner.GetMinerReport();

            var time = DateTime.Now;

            _hashrateSeries.Points.Add(new DataPoint(time.ToOADate(), Convert.ToDouble(report.TotalHashrate * 1000)));
            _difficultySeries.Points.Add(new DataPoint(time.ToOADate(), Convert.ToDouble(report.BlockDifficulty)));
            _acceptedSeries.Points.Add(new DataPoint(time.ToOADate(), Convert.ToDouble(report.AcceptedShares)));
            _staleSeries.Points.Add(new DataPoint(time.ToOADate(), Convert.ToDouble(report.StaleShares)));

            DateTime scroll = time.AddHours(-1);

            chart1.ChartAreas[0].AxisX.Minimum = scroll.ToOADate();
            chart1.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            chart2.ChartAreas[0].AxisX.Minimum = scroll.ToOADate();
            chart2.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(1).ToOADate();

            if (_hashrateSeries.Points.Count > 720)
            {
                _hashrateSeries.Points.RemoveAt(0);
            }
            if (_difficultySeries.Points.Count > 720)
            {
                _difficultySeries.Points.RemoveAt(0);
            }

            if (_acceptedSeries.Points.Count > 720)
            {
                _acceptedSeries.Points.RemoveAt(0);
            }
            if (_staleSeries.Points.Count > 720)
            {
                _staleSeries.Points.RemoveAt(0);
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void minibtn_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }


        private void algorithmBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idleBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://starpool.fun");
        }


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Miner_MouseDown(object sender,
        System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
