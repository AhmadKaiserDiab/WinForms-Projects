using System;
using System.Windows.Forms;

namespace PoolClubProject
{
    public partial class ctrlPoolTable : UserControl
    {
        public class TableEndedEventArgs : EventArgs
        {
            public string TotalTimeText { get; }
            public int TotalTimeInSeconds { get; }
            public double HourlyRate { get; }
            public double TotalFees { get; }

            internal TableEndedEventArgs(string TotalTimeText, int TotalTimeInSeconds,
                double HourlyRate, double TotalFess)
            {
                this.TotalTimeText = TotalTimeText;
                this.TotalTimeInSeconds = TotalTimeInSeconds;
                this.HourlyRate = HourlyRate;
                this.TotalFees = TotalFess;
            }
        }

        public EventHandler<TableEndedEventArgs> OnTableEnded;

        protected void TableEnded(TableEndedEventArgs e)
        {
            OnTableEnded?.Invoke(this, e);
        }

        protected void TableEnded(string TotalTimeText, int TotalTimeInSeconds,
                double HourlyRate, double TotalFees)
        {
            TableEnded(new TableEndedEventArgs(TotalTimeText, TotalTimeInSeconds,
                HourlyRate, TotalFees));
        }

        private string _TableName = "";
        private string _PlayerName = "";
        private double _HourlyRate = 0;
        private int _TotalSeconds = 0;

        public string TableName
        {
            get
            {
                return _TableName;
            }

            set
            {
                _TableName = value;
                grbTable.Text = value;
            }
        }

        public string PlayerName
        {
            get
            {
                return _PlayerName;
            }

            set
            {
                _PlayerName = value;
                lblPlayerName.Text = value;
            }
        }

        public double HourlyRate
        {
            get
            {
                return _HourlyRate;
            }

            set
            {
                _HourlyRate = value;
            }
        }

        public ctrlPoolTable()
        {
            InitializeComponent();
        }

        private void btnStartStop_Click(object sender, System.EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
                timer1.Start();
            }
            else
            {
                btnStartStop.Text = "Start";
                timer1.Stop();
            }
        }

        private void btnEnd_Click(object sender, System.EventArgs e)
        {
            if (!timer1.Enabled && _TotalSeconds == 0)
            {
                return;
            }

            timer1.Stop();
            TimeSpan span = TimeSpan.FromSeconds(_TotalSeconds);
            string TotalTimeText = span.ToString(@"hh\:mm\:ss");
            double TotalFees = (_TotalSeconds * _HourlyRate) / 60 / 60;
            TableEnded(TotalTimeText, _TotalSeconds, HourlyRate, TotalFees);

            _ResetControl();
        }

        private void _ResetControl()
        {
            _TotalSeconds = 0;
            lblTime.Text = "00:00:00";
            btnStartStop.Text = "Start";
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            _TotalSeconds++;

            lblTime.Text = TimeSpan.FromSeconds(_TotalSeconds).ToString(@"hh\:mm\:ss");
            lblTime.Refresh();
        }

    }
}
