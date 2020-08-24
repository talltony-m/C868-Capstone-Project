using System;
using System.Windows.Forms;

namespace C868
{
    public partial class MainForm : Form
    {
        public Login loginForm;
        public MainForm()
        {
            InitializeComponent();
        }

        private void rosterButton_Click(object sender, EventArgs e)
        {
            MainRoster mainRoster = new MainRoster();
            mainRoster.Show();
        }

        private void scheduleButton_Click(object sender, EventArgs e)
        {
            MainSchedule mainSchedule = new MainSchedule();
            mainSchedule.Show();
        }
    }
}
