using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C868
{
    public partial class DeleteSchedule : Form
    {

        public MainSchedule mainScheduleObject;

        public DeleteSchedule()
        {
            InitializeComponent();
        }

        private void DeleteSchedule_Load(object sender, EventArgs e)
        {

        }
        public static Dictionary<string, string> appointmentDetails = new Dictionary<string, string>();

        public static bool DeleteApp()
        {
            MySqlConnection c = new MySqlConnection(SqlUpdater.conString);
            c.Open();

            string recDelete = $"DELETE FROM appointment" +
                $" WHERE appointmentId = '{appointmentDetails["appointmentId"]}'";
            MySqlCommand cmd = new MySqlCommand(recDelete, c);
            int appointmentDeleted = cmd.ExecuteNonQuery();
            c.Close();

            if (appointmentDeleted != 0)
                return true;
            else
                return false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string appointmentId = SearchBox.Text;
            appointmentDetails = SqlUpdater.GetAppointmentDetails(appointmentId);
            TeamIdLabel.Text = appointmentDetails["customerId"];
            TypeLabel.Text = appointmentDetails["type"];
            StartLabel.Text = appointmentDetails["start"];
            EndLabel.Text = appointmentDetails["end"];
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this Schedule?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                if (DeleteApp())
                    MessageBox.Show($"Schedule: {appointmentDetails["type"]} was deleted");
                else
                    MessageBox.Show($"Schedule: {appointmentDetails["type"]} was not deleted");

            }
            Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EndLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
