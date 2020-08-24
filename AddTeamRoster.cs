using System;
using System.Windows.Forms;

namespace C868
{
    public partial class AddTeamRoster : Form
    {
        Team team = new Team();
        public AddTeamRoster()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(TeamIdBox.Text) || String.IsNullOrWhiteSpace(TeamNameBox.Text) || String.IsNullOrWhiteSpace(TeamCityBox.Text) || String.IsNullOrWhiteSpace(TeamPhoneBox.Text))
            {
                MessageBox.Show("Fields cannot be empty.");
                return;
            }

            else
            {
                try
                {
                    Team team = new Team(int.Parse(TeamIdBox.Text), TeamNameBox.Text, TeamCityBox.Text, TeamPhoneBox.Text);
                    Inventory.AddTeam(team);
                }
                catch (Exception)
                {
                    MessageBox.Show("Something went wrong.");
                    throw;
                }
                this.Close();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
