namespace ccminer_gui
{
    partial class Miner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Miner));
            this.algorithmBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.poolUrlBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.intensityBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpuStatsBox = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.idleBox = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label8 = new System.Windows.Forms.Label();
            this.totalHashrateLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.totalSharesLabel = new System.Windows.Forms.Label();
            this.acceptedSharesLabel = new System.Windows.Forms.Label();
            this.staleSharesLabel = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.blockLabel = new System.Windows.Forms.Label();
            this.stratumDifficultyLabel = new System.Windows.Forms.Label();
            this.blockDifficultyLabel = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTimer = new System.Windows.Forms.Timer(this.components);
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.exitbtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.minibtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gpuStatsBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // algorithmBox
            // 
            this.algorithmBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.algorithmBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.algorithmBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.algorithmBox.FormattingEnabled = true;
            this.algorithmBox.Location = new System.Drawing.Point(911, 246);
            this.algorithmBox.Name = "algorithmBox";
            this.algorithmBox.Size = new System.Drawing.Size(203, 37);
            this.algorithmBox.TabIndex = 0;
            this.algorithmBox.SelectedIndexChanged += new System.EventHandler(this.algorithmBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(907, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Algorithm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "User / Wallet";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.usernameBox.Location = new System.Drawing.Point(15, 47);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(564, 35);
            this.usernameBox.TabIndex = 3;
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.passwordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.passwordBox.Location = new System.Drawing.Point(16, 209);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(221, 35);
            this.passwordBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Password";
            // 
            // poolUrlBox
            // 
            this.poolUrlBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.poolUrlBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.poolUrlBox.Location = new System.Drawing.Point(15, 124);
            this.poolUrlBox.Name = "poolUrlBox";
            this.poolUrlBox.Size = new System.Drawing.Size(564, 38);
            this.poolUrlBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pool URL";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.SeaGreen;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaGreen;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.startButton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.startButton.Location = new System.Drawing.Point(582, 331);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(546, 54);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start Raven Miner";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // intensityBox
            // 
            this.intensityBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.intensityBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.intensityBox.Location = new System.Drawing.Point(260, 208);
            this.intensityBox.Name = "intensityBox";
            this.intensityBox.Size = new System.Drawing.Size(145, 35);
            this.intensityBox.TabIndex = 9;
            this.intensityBox.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(256, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Intensity";
            // 
            // gpuStatsBox
            // 
            this.gpuStatsBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(122)))));
            this.gpuStatsBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.gpuStatsBox.Location = new System.Drawing.Point(430, 208);
            this.gpuStatsBox.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.gpuStatsBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.gpuStatsBox.Name = "gpuStatsBox";
            this.gpuStatsBox.Size = new System.Drawing.Size(146, 35);
            this.gpuStatsBox.TabIndex = 11;
            this.gpuStatsBox.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(426, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "GPU Stats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(592, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status:";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(684, 144);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(74, 20);
            this.statusLabel.TabIndex = 15;
            this.statusLabel.Text = "Stopped.";
            // 
            // idleBox
            // 
            this.idleBox.AutoSize = true;
            this.idleBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.idleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.idleBox.ForeColor = System.Drawing.Color.White;
            this.idleBox.Location = new System.Drawing.Point(801, 297);
            this.idleBox.Name = "idleBox";
            this.idleBox.Size = new System.Drawing.Size(230, 28);
            this.idleBox.TabIndex = 16;
            this.idleBox.Text = "Only run while PC is idle";
            this.idleBox.UseVisualStyleBackColor = true;
            this.idleBox.CheckedChanged += new System.EventHandler(this.idleBox_CheckedChanged);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(143)))), ((int)(((byte)(47)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 285);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(564, 420);
            this.listBox1.TabIndex = 17;
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(650, 45);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 25);
            this.label8.TabIndex = 18;
            this.label8.Text = "Total Hashrate";
            // 
            // totalHashrateLabel
            // 
            this.totalHashrateLabel.AutoSize = true;
            this.totalHashrateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.totalHashrateLabel.ForeColor = System.Drawing.Color.White;
            this.totalHashrateLabel.Location = new System.Drawing.Point(5, 12);
            this.totalHashrateLabel.Name = "totalHashrateLabel";
            this.totalHashrateLabel.Size = new System.Drawing.Size(102, 31);
            this.totalHashrateLabel.TabIndex = 19;
            this.totalHashrateLabel.Text = "0 KH/s";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label9.ForeColor = System.Drawing.Color.LawnGreen;
            this.label9.Location = new System.Drawing.Point(941, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 18);
            this.label9.TabIndex = 20;
            this.label9.Text = "Total Shares:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label10.ForeColor = System.Drawing.Color.LawnGreen;
            this.label10.Location = new System.Drawing.Point(941, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 18);
            this.label10.TabIndex = 21;
            this.label10.Text = "Accepted Shares:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(941, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 18);
            this.label11.TabIndex = 22;
            this.label11.Text = "Stale Shares:";
            // 
            // totalSharesLabel
            // 
            this.totalSharesLabel.AutoSize = true;
            this.totalSharesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.totalSharesLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.totalSharesLabel.Location = new System.Drawing.Point(1081, 110);
            this.totalSharesLabel.Name = "totalSharesLabel";
            this.totalSharesLabel.Size = new System.Drawing.Size(16, 18);
            this.totalSharesLabel.TabIndex = 23;
            this.totalSharesLabel.Text = "0";
            // 
            // acceptedSharesLabel
            // 
            this.acceptedSharesLabel.AutoSize = true;
            this.acceptedSharesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.acceptedSharesLabel.ForeColor = System.Drawing.Color.LawnGreen;
            this.acceptedSharesLabel.Location = new System.Drawing.Point(1081, 143);
            this.acceptedSharesLabel.Name = "acceptedSharesLabel";
            this.acceptedSharesLabel.Size = new System.Drawing.Size(16, 18);
            this.acceptedSharesLabel.TabIndex = 24;
            this.acceptedSharesLabel.Text = "0";
            // 
            // staleSharesLabel
            // 
            this.staleSharesLabel.AutoSize = true;
            this.staleSharesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.staleSharesLabel.ForeColor = System.Drawing.Color.Red;
            this.staleSharesLabel.Location = new System.Drawing.Point(1081, 175);
            this.staleSharesLabel.Name = "staleSharesLabel";
            this.staleSharesLabel.Size = new System.Drawing.Size(16, 18);
            this.staleSharesLabel.TabIndex = 25;
            this.staleSharesLabel.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(592, 183);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(134, 20);
            this.label15.TabIndex = 26;
            this.label15.Text = "Stratum Difficulty:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(592, 221);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(116, 20);
            this.label16.TabIndex = 27;
            this.label16.Text = "Block Difficulty:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(592, 258);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 20);
            this.label17.TabIndex = 28;
            this.label17.Text = "Block:";
            // 
            // blockLabel
            // 
            this.blockLabel.AutoSize = true;
            this.blockLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.blockLabel.ForeColor = System.Drawing.Color.White;
            this.blockLabel.Location = new System.Drawing.Point(740, 258);
            this.blockLabel.Name = "blockLabel";
            this.blockLabel.Size = new System.Drawing.Size(18, 20);
            this.blockLabel.TabIndex = 29;
            this.blockLabel.Text = "0";
            // 
            // stratumDifficultyLabel
            // 
            this.stratumDifficultyLabel.AutoSize = true;
            this.stratumDifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.stratumDifficultyLabel.ForeColor = System.Drawing.Color.White;
            this.stratumDifficultyLabel.Location = new System.Drawing.Point(740, 183);
            this.stratumDifficultyLabel.Name = "stratumDifficultyLabel";
            this.stratumDifficultyLabel.Size = new System.Drawing.Size(18, 20);
            this.stratumDifficultyLabel.TabIndex = 30;
            this.stratumDifficultyLabel.Text = "0";
            // 
            // blockDifficultyLabel
            // 
            this.blockDifficultyLabel.AutoSize = true;
            this.blockDifficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.blockDifficultyLabel.ForeColor = System.Drawing.Color.White;
            this.blockDifficultyLabel.Location = new System.Drawing.Point(740, 221);
            this.blockDifficultyLabel.Name = "blockDifficultyLabel";
            this.blockDifficultyLabel.Size = new System.Drawing.Size(18, 20);
            this.blockDifficultyLabel.TabIndex = 31;
            this.blockDifficultyLabel.Text = "0";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.chart1.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chart1.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea7.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea7.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MajorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MinorGrid.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea7.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea7.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            chartArea7.BorderColor = System.Drawing.SystemColors.Control;
            chartArea7.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea7);
            legend7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            legend7.ForeColor = System.Drawing.Color.White;
            legend7.Name = "Legend1";
            this.chart1.Legends.Add(legend7);
            this.chart1.Location = new System.Drawing.Point(582, 400);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(546, 170);
            this.chart1.TabIndex = 32;
            this.chart1.Text = "chart1";
            // 
            // chartTimer
            // 
            this.chartTimer.Enabled = true;
            this.chartTimer.Interval = 60000;
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.chart2.BackSecondaryColor = System.Drawing.SystemColors.Control;
            this.chart2.BorderlineColor = System.Drawing.SystemColors.Control;
            chartArea8.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisX.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.MinorTickMark.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.ScaleBreakStyle.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea8.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisX2.LineColor = System.Drawing.Color.White;
            chartArea8.AxisX2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisY.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea8.AxisY2.LineColor = System.Drawing.Color.White;
            chartArea8.AxisY2.MajorGrid.LineColor = System.Drawing.Color.White;
            chartArea8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            chartArea8.BorderColor = System.Drawing.SystemColors.Control;
            chartArea8.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea8);
            legend8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            legend8.ForeColor = System.Drawing.Color.White;
            legend8.Name = "Legend1";
            this.chart2.Legends.Add(legend8);
            this.chart2.Location = new System.Drawing.Point(582, 563);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(546, 170);
            this.chart2.TabIndex = 33;
            this.chart2.Text = "chart2";
            // 
            // exitbtn
            // 
            this.exitbtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(64)))));
            this.exitbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitbtn.BorderRadius = 0;
            this.exitbtn.ButtonText = "Exit";
            this.exitbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitbtn.DisabledColor = System.Drawing.Color.Gray;
            this.exitbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.exitbtn.Iconcolor = System.Drawing.Color.Transparent;
            this.exitbtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("exitbtn.Iconimage")));
            this.exitbtn.Iconimage_right = null;
            this.exitbtn.Iconimage_right_Selected = null;
            this.exitbtn.Iconimage_Selected = null;
            this.exitbtn.IconMarginLeft = 0;
            this.exitbtn.IconMarginRight = 0;
            this.exitbtn.IconRightVisible = true;
            this.exitbtn.IconRightZoom = 0D;
            this.exitbtn.IconVisible = false;
            this.exitbtn.IconZoom = 90D;
            this.exitbtn.IsTab = false;
            this.exitbtn.Location = new System.Drawing.Point(1034, -4);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(64)))));
            this.exitbtn.OnHovercolor = System.Drawing.Color.Red;
            this.exitbtn.OnHoverTextColor = System.Drawing.Color.White;
            this.exitbtn.selected = false;
            this.exitbtn.Size = new System.Drawing.Size(80, 48);
            this.exitbtn.TabIndex = 34;
            this.exitbtn.Text = "Exit";
            this.exitbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitbtn.Textcolor = System.Drawing.Color.White;
            this.exitbtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // minibtn
            // 
            this.minibtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.minibtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(64)))));
            this.minibtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minibtn.BorderRadius = 0;
            this.minibtn.ButtonText = "Minimize";
            this.minibtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minibtn.DisabledColor = System.Drawing.Color.Gray;
            this.minibtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.minibtn.Iconcolor = System.Drawing.Color.Transparent;
            this.minibtn.Iconimage = ((System.Drawing.Image)(resources.GetObject("minibtn.Iconimage")));
            this.minibtn.Iconimage_right = null;
            this.minibtn.Iconimage_right_Selected = null;
            this.minibtn.Iconimage_Selected = null;
            this.minibtn.IconMarginLeft = 0;
            this.minibtn.IconMarginRight = 0;
            this.minibtn.IconRightVisible = true;
            this.minibtn.IconRightZoom = 0D;
            this.minibtn.IconVisible = false;
            this.minibtn.IconZoom = 90D;
            this.minibtn.IsTab = false;
            this.minibtn.Location = new System.Drawing.Point(944, -4);
            this.minibtn.Name = "minibtn";
            this.minibtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(64)))));
            this.minibtn.OnHovercolor = System.Drawing.Color.Red;
            this.minibtn.OnHoverTextColor = System.Drawing.Color.White;
            this.minibtn.selected = false;
            this.minibtn.Size = new System.Drawing.Size(80, 48);
            this.minibtn.TabIndex = 35;
            this.minibtn.Text = "Minimize";
            this.minibtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minibtn.Textcolor = System.Drawing.Color.White;
            this.minibtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minibtn.Click += new System.EventHandler(this.minibtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(790, 150);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 36;
            this.pictureBox1.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(267, 246);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 18);
            this.label12.TabIndex = 37;
            this.label12.Text = "(Default 0 for Auto)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(454, 246);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 18);
            this.label13.TabIndex = 38;
            this.label13.Text = " (in seconds)";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "GUI Made By StarPool.fun Raven Mining Pool";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton1.Iconimage")));
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = false;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(238, 88);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(149)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Red;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(341, 30);
            this.bunifuFlatButton1.TabIndex = 39;
            this.bunifuFlatButton1.Text = "GUI Made By StarPool.fun Raven Mining Pool";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1.Controls.Add(this.totalHashrateLabel);
            this.panel1.Location = new System.Drawing.Point(612, -5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 49);
            this.panel1.TabIndex = 40;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(590, 99);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(238, 31);
            this.label14.TabIndex = 41;
            this.label14.Text = "Raven GUI Miner";
            // 
            // Miner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1126, 736);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.minibtn);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.blockDifficultyLabel);
            this.Controls.Add(this.stratumDifficultyLabel);
            this.Controls.Add(this.blockLabel);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.staleSharesLabel);
            this.Controls.Add(this.acceptedSharesLabel);
            this.Controls.Add(this.totalSharesLabel);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.idleBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gpuStatsBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.intensityBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.poolUrlBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.algorithmBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Miner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RavenMiner GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Miner_FormClosing);
            this.Load += new System.EventHandler(this.Miner_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Miner_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.gpuStatsBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox algorithmBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox poolUrlBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox intensityBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown gpuStatsBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.CheckBox idleBox;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label totalHashrateLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label totalSharesLabel;
        private System.Windows.Forms.Label acceptedSharesLabel;
        private System.Windows.Forms.Label staleSharesLabel;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label blockLabel;
        private System.Windows.Forms.Label stratumDifficultyLabel;
        private System.Windows.Forms.Label blockDifficultyLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Timer chartTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Bunifu.Framework.UI.BunifuFlatButton exitbtn;
        private Bunifu.Framework.UI.BunifuFlatButton minibtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
    }
}

