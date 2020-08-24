using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace C868
{
    public partial class DeleteTeam : Form
    {
        public DeleteTeam()
        {
            InitializeComponent();
        }

        public static Dictionary<string, string> customerDetails = new Dictionary<string, string>();

        public bool DeleteCust()
        {
            MySqlConnection c = new MySqlConnection(SqlUpdater.conString);
            c.Open();

            string recUpdate = $"DELETE FROM customer" +
                $" WHERE customerName = '{customerDetails["customerName"]}'";
            MySqlCommand cmd = new MySqlCommand(recUpdate, c);
            int customerUpdated = cmd.ExecuteNonQuery();

            recUpdate = $"DELETE FROM address" +
                $" WHERE address = '{customerDetails["address"]}'";
            cmd = new MySqlCommand(recUpdate, c);
            int addressUpdated = cmd.ExecuteNonQuery();

            c.Close();

            if (customerUpdated != 0 && addressUpdated != 0)
                return true;
            else
                return false;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int customerId = SqlUpdater.FindCustomer(SearchBar.Text);
            if (customerId != 0)
            {
                customerDetails = SqlUpdater.GetCustomerDetails(customerId);
                nameLabel.Text = customerDetails["customerName"];
                phoneLabel.Text = customerDetails["phone"];
                addressLabel.Text = customerDetails["address"];
                cityLabel.Text = customerDetails["city"];
                zipLabel.Text = customerDetails["zip"];
                countryLabel.Text = customerDetails["country"];
            }
            else
            {
                MessageBox.Show("Unable to find team");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)

        {
            DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete this Team?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                if (DeleteCust())
                    MessageBox.Show($"Team: {customerDetails["customerName"]} was deleted");
                else
                    MessageBox.Show($"Team: {customerDetails["customerName"]} was not deleted");

            }
        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
