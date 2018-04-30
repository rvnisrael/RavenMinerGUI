using ccminer_gui.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace ccminer_gui
{
    class CCMinerInterop
    {
        public event DataReceivedEventHandler OutputDataReceived;
        public event DataReceivedEventHandler ErrorDataReceived;

        public CCMinerInterop()
        {
            _minerCli = new MinerCli();

            _minerCli.OutputDataReceived += _minerCli_OutputDataReceived;
            _minerCli.ErrorDataReceived += _minerCli_ErrorDataReceived;

            _algorithms = new List<Algorithm>()
            {

                Algorithm.Create("x16r", "RavenCoin"),
            };
        }

        public string FindAlgorithmName(string algorithmName)
        {
            return Algorithm.FindByArgument(algorithmName, _algorithms).Name;
        }

        public List<string> GetList()
        {
            return Algorithm.GetNames(_algorithms);
        }

        public void Run(IConfig config)
        {
            var algorithm = Algorithm.Find(config.Algorithm, _algorithms).Argument;
            _minerCli.Run(config, algorithm);
        }

        public MinerReport GetMinerReport()
        {
            return _minerCli.MinerReport;
        }

        public void ResetMinerReport()
        {
            _minerCli.MinerReport = new MinerReport();
        }

        private void _minerCli_ErrorDataReceived(object sender, DataReceivedEventArgs e)
        {
            ErrorDataReceived?.Invoke(sender, e);
        }

        private void _minerCli_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            OutputDataReceived?.Invoke(sender, e);
        }

        public void Stop()
        {
            _minerCli.Close();
        }

        public bool IsRunning
        {
            get
            {
                return !_minerCli.Closed;
            }
        }

        private List<Algorithm> _algorithms;
        private MinerCli _minerCli;
    }
}
