using System;
using System.Windows.Forms;



namespace C868
{
    public partial class AddTeam : Form
    {

        public AddTeam()
        {
            InitializeComponent();
        }

        private void TeamAddButton_Click(object sender, EventArgs e)
        {
            string timestamp = SqlUpdater.CreateTimestamp();
            string userName = SqlUpdater.GetCurrentUserName();

            if (string.IsNullOrEmpty(TeamNameText.Text) ||
                string.IsNullOrEmpty(TeamPhoneText.Text) ||
                string.IsNullOrEmpty(TeamCityText.Text) ||
                string.IsNullOrEmpty(TeamCountryText.Text) ||
                string.IsNullOrEmpty(TeamZipText.Text) ||
                string.IsNullOrEmpty(TeamAddressText.Text))
            {
                MessageBox.Show("Please complete all fields");
            }
            else
            {
                int countryId = SqlUpdater.CreateRecord(timestamp, userName, "country", $"'{TeamCountryText.Text}'");
                int cityId = SqlUpdater.CreateRecord(timestamp, userName, "city", $"'{TeamCityText.Text}', '{countryId}'");
                int addressId = SqlUpdater.CreateRecord(timestamp, userName, "address", $"'{TeamAddressText.Text}', '', '{cityId}', '{TeamZipText.Text}', '{TeamPhoneText.Text}'");
                SqlUpdater.CreateRecord(timestamp, userName, "customer", $"'{TeamNameText.Text}', '{addressId}', '1'");

                MessageBox.Show("Team created.");
                Close();
            }
        }

        private void TeamCancelButton_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
