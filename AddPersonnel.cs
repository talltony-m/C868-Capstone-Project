using System;
using System.Windows.Forms;

namespace C868
{
    public partial class AddPersonnel : Form
    {
        public AddPersonnel()
        {
            InitializeComponent();
            AgencyButton.Checked = true;
        }

        private void AgencyButton_CheckedChanged(object sender, EventArgs e)
        {
            AffiliationLabel.Text = "Agency ID";
        }

        private void OutsourcedButton_CheckedChanged(object sender, EventArgs e)
        {
            AffiliationLabel.Text = "Hiring Agency Contact";
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            if (AgencyButton.Checked)
            {

                AgencyButton.Checked = true;
                Agency agencyPersonnel = new Agency(int.Parse(PerIdBox.Text), PerNameBox.Text, PerPositionBox.Text, PerPhoneBox.Text, PerCityBox.Text, decimal.Parse(PerRateBox.Text), int.Parse(AffiliationBox.Text));
                if (String.IsNullOrWhiteSpace(PerNameBox.Text))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                if (int.Parse(PerIdBox.Text) != agencyPersonnel.PersonnelId)
                {
                    MessageBox.Show("Cannot alter Personnel ID.");
                    return;

                }
                else
                {
                    Inventory.AddPersonnel(agencyPersonnel);
                }

            }
            else
            {
                OutsourcedButton.Checked = true;
                Outsourced outsourcedPersonnel = new Outsourced(int.Parse(PerIdBox.Text), PerNameBox.Text, PerPositionBox.Text, PerPhoneBox.Text, PerCityBox.Text, decimal.Parse(PerRateBox.Text), AffiliationBox.Text);
                if (String.IsNullOrWhiteSpace(PerNameBox.Text))
                {
                    throw new ArgumentNullException("Name cannot be empty.");
                }
                if (int.Parse(PerIdBox.Text) != outsourcedPersonnel.PersonnelId)
                {
                    MessageBox.Show("Cannot change Personnel ID.");
                    return;
                }
                else
                {
                    Inventory.AddPersonnel(outsourcedPersonnel);
                }
            }
            Close();
        }

        private void CancelButton_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
