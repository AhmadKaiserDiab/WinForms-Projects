using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace TrafficLightProject
{
    public partial class ctrlTrafficLight : UserControl
    {
        public class TrafficLightEventArgs : EventArgs
        {
            public enLightColor CurrentColor { get; }
            public enLightColor PreviousColor { get; }
            public enLightColor NextColor { get; }
            public short WaitingTime { get; }

            internal TrafficLightEventArgs(enLightColor CurrentColor, enLightColor PreviousColor, enLightColor NextColor, short WaitingTime)
            {
                this.CurrentColor = CurrentColor;
                this.PreviousColor = PreviousColor;
                this.NextColor = NextColor;
                this.WaitingTime = WaitingTime;
            }
        }

        public EventHandler<TrafficLightEventArgs> OnTrafficLightChanged;

        protected void TrafficLightChanged(TrafficLightEventArgs e)
        {
            OnTrafficLightChanged?.Invoke(this, e);
        }

        protected void TrafficLightChanged(enLightColor CurrentColor, enLightColor PreviousColor, enLightColor NextColor, short WaitingTime)
        {
            TrafficLightChanged(new TrafficLightEventArgs(CurrentColor, PreviousColor, NextColor, WaitingTime));
        }

        public enum enLightColor { Red = 1, Orange = 2, Green = 3 };

        private enLightColor _PreviousColor = enLightColor.Red;
        private enLightColor _CurrentColor = enLightColor.Red;
        private short _RedColorWaitingTime;
        private short _OrangeColorWaitingTime;
        private short _GreenColorWaitingTime;
        private short _CurrentWaitingTime;

        [Category("Global Properities")]
        public enLightColor CurrentColor
        {
            get
            {
                return _CurrentColor;
            }
            set
            {
                _CurrentColor = value;
                ChangeCurrentColorPicture();
                ChangeCurrentColorWaitingTime();
                ChangeCurrentWaitingTimeColor();
            }
        }

        [Category("Global Properities")]
        public short RedColorWaitingTime
        {
            get
            {
                return _RedColorWaitingTime;
            }

            set
            {
                _RedColorWaitingTime = value;
                ChangeCurrentColorWaitingTime();
            }
        }

        [Category("Global Properities")]
        public short OrangeColorWaitingTime
        {
            get
            {
                return _OrangeColorWaitingTime;
            }

            set
            {
                _OrangeColorWaitingTime = value;
                ChangeCurrentColorWaitingTime();
            }
        }

        [Category("Global Properities")]
        public short GreenColorWaitingTime
        {
            get
            {
                return _GreenColorWaitingTime;
            }
            set
            {
                _GreenColorWaitingTime = value;
                ChangeCurrentColorWaitingTime();
            }
        }

        public short GetCurrentWaitingTime()
        {
            switch (CurrentColor)
            {
                case enLightColor.Red:
                    return RedColorWaitingTime;
                case enLightColor.Orange:
                    return OrangeColorWaitingTime;
                case enLightColor.Green:
                    return GreenColorWaitingTime;
            }
            return RedColorWaitingTime;
        }

        public ctrlTrafficLight()
        {
            InitializeComponent();
        }

        private void ChangeCurrentColorPicture()
        {
            switch (CurrentColor)
            {
                case enLightColor.Red:
                    pbTrafficLight.Image = Properties.Resources.Red;
                    break;
                case enLightColor.Orange:
                    pbTrafficLight.Image = Properties.Resources.Orange;
                    break;
                case enLightColor.Green:
                    pbTrafficLight.Image = Properties.Resources.Green;
                    break;
            }
        }

        private void ChangeCurrentColorWaitingTime()
        {
            switch (CurrentColor)
            {
                case enLightColor.Red:
                    _CurrentWaitingTime = RedColorWaitingTime;
                    lblRemainigTime.Text = RedColorWaitingTime.ToString();
                    break;
                case enLightColor.Orange:
                    _CurrentWaitingTime = OrangeColorWaitingTime;
                    lblRemainigTime.Text = OrangeColorWaitingTime.ToString();
                    break;
                case enLightColor.Green:
                    _CurrentWaitingTime = GreenColorWaitingTime;
                    lblRemainigTime.Text = GreenColorWaitingTime.ToString();
                    break;
            }
        }

        private void ChangeCurrentWaitingTimeColor()
        {
            switch (_CurrentColor)
            {
                case enLightColor.Red:
                    lblRemainigTime.ForeColor = System.Drawing.Color.Red;
                    break;
                case enLightColor.Orange:
                    lblRemainigTime.ForeColor = System.Drawing.Color.Orange;
                    break;
                case enLightColor.Green:
                    lblRemainigTime.ForeColor = System.Drawing.Color.Green;
                    break;
            }
        }

        public void Start()
        {
            _CurrentWaitingTime = GetCurrentWaitingTime();
            timer1.Start();
        }

        private void SetNextColor()
        {
            enLightColor NextColor;
            if (CurrentColor == enLightColor.Red)
            {
                _PreviousColor = enLightColor.Red;
                CurrentColor = enLightColor.Orange;
                NextColor = enLightColor.Green;
            }
            else if (CurrentColor == enLightColor.Green)
            {
                _PreviousColor = enLightColor.Green;
                CurrentColor = enLightColor.Orange;
                NextColor = enLightColor.Red;
            }
            else if (CurrentColor == enLightColor.Orange &&
                    _PreviousColor == enLightColor.Green)
            {
                _PreviousColor = enLightColor.Orange;
                CurrentColor = enLightColor.Red;
                NextColor = enLightColor.Orange;
            }
            else
            {
                _PreviousColor = enLightColor.Orange;
                CurrentColor = enLightColor.Green;
                NextColor = enLightColor.Orange;
            }
            TrafficLightChanged(CurrentColor, _PreviousColor, NextColor, _CurrentWaitingTime);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_CurrentWaitingTime == 1)
            {
                SetNextColor();
            }
            else
            {
                _CurrentWaitingTime --;
                lblRemainigTime.Text = _CurrentWaitingTime.ToString();
            }
        }

    }
}
