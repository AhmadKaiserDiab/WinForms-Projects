using System;
using System.Windows.Forms;

namespace TrafficLightProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ctrlTrafficLight1.OnTrafficLightChanged += GetData;
            //ctrlTrafficLight2.OnTrafficLightChanged += GetData;
            //ctrlTrafficLight3.OnTrafficLightChanged += GetData;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            ctrlTrafficLight1.Start();
            ctrlTrafficLight2.Start();
            ctrlTrafficLight3.Start();
        }

        private void GetData(object sender, ctrlTrafficLight.TrafficLightEventArgs e)
        {
            string traffic = ((Control)sender).Tag.ToString();

            MessageBox.Show(
                text: $"Traffic Light Info: \n" +
                        $"Current Light: {e.CurrentColor.ToString()} \n" +
                        $"Previous Light: {e.PreviousColor.ToString()} \n" +
                        $"NexT Light: {e.NextColor.ToString()} \n" +
                        $"Waiting Time For Next One: {e.WaitingTime.ToString()}",
                caption: traffic);
        }

    }
}
