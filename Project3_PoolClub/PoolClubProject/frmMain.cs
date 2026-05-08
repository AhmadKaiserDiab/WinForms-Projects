using System.Windows.Forms;

namespace PoolClubProject
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            ctrlPoolTable1.OnTableEnded += ctrlPoolTable_OnTableEnded; 
            ctrlPoolTable2.OnTableEnded += ctrlPoolTable_OnTableEnded; 
            ctrlPoolTable3.OnTableEnded += ctrlPoolTable_OnTableEnded; 
            ctrlPoolTable4.OnTableEnded += ctrlPoolTable_OnTableEnded;
        }

        private void ctrlPoolTable_OnTableEnded(object sender, ctrlPoolTable.TableEndedEventArgs e)
        {
            string TableResults = "";

            TableResults = "Time Consumed  " + e.TotalTimeText;
            TableResults = TableResults + ", Total Seconds = " + e.TotalTimeInSeconds;
            TableResults = TableResults + ", HourlyRate = " + e.HourlyRate.ToString();
            TableResults = TableResults + ", Total Fees = " + e.TotalFees.ToString();

            MessageBox.Show(TableResults);
        }
    }
}
