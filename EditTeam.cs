using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C868
{
    public partial class EditTeam : Form
    {
        public EditTeam()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> cForm = new Dictionary<string, string>();

        public bool UpdateCust(Dictionary<string, string> updatedForm)
        {
            MySqlConnection c = new MySqlConnection(SqlUpdater.conString);
            c.Open();

            string recUpdate = $"UPDATE customer" +
                $" SET customerName = '{updatedForm["customerName"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE customerName = '{cForm["customerName"]}'";
            MySqlCommand cmd = new MySqlCommand(recUpdate, c);
            int customerUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"UPDATE address" +
                $" SET address = '{updatedForm["address"]}', postalCode = '{updatedForm["zip"]}', phone = '{updatedForm["phone"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE address = '{cForm["address"]}'";
            cmd = new MySqlCommand(recUpdate, c);
            int addressUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"UPDATE city" +
                $" SET city = '{updatedForm["city"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE city = '{cForm["city"]}'";
            cmd = new MySqlCommand(recUpdate, c);
            int cityUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"UPDATE country" +
                $" SET country = '{updatedForm["country"]}', lastUpdate = '{SqlUpdater.CreateTimestamp()}', lastUpdateBy = '{SqlUpdater.GetCurrentUserName()}'" +
                $" WHERE country = '{cForm["country"]}'";
            cmd = new MySqlCommand(recUpdate, c);
            int countryUpdated = cmd.ExecuteNonQuery();

            c.Close();

            if (customerUpdated != 0 && addressUpdated != 0 && cityUpdated != 0 && countryUpdated != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            {
                int customerId = SqlUpdater.FindCustomer(SearchBar.Text);
                if (customerId != 0)
                {
                    cForm = SqlUpdater.GetCustomerDetails(customerId);
                    TeamNameBox.Text = cForm["customerName"];
                    TeamPhoneBox.Text = cForm["phone"];
                    TeamCityBox.Text = cForm["city"];
                    TeamAddressBox.Text = cForm["address"];
                    TeamZipBox.Text = cForm["zip"];
                    TeamCountryBox.Text = cForm["country"];
                }
                else
                {
                    MessageBox.Show("Unable to find Team");
                }
            }
        }

        private void SaveBbutton_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> updatedForm = new Dictionary<string, string>
            {
                { "customerName", TeamNameBox.Text },
                { "phone", TeamPhoneBox.Text },
                { "address", TeamAddressBox.Text },
                { "city", TeamCityBox.Text },
                { "country", TeamCountryBox.Text },
                { "zip", TeamZipBox.Text },
            };

            if (UpdateCust(updatedForm))
            {
                MessageBox.Show("Updated succesfull");
            }
            else
            {
                MessageBox.Show("Update failed");
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
