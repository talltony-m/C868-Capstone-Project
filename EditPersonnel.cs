using System;
using System.Windows.Forms;

namespace C868
{
    public partial class EditPersonnel : Form
    {
        public EditPersonnel()
        {
            InitializeComponent();
        }

        public EditPersonnel(Agency agency)
        {
            InitializeComponent();

            PerIdBox.Text = Convert.ToString(agency.PersonnelId);
            PerNameBox.Text = agency.Name;
            PerCityBox.Text = Convert.ToString(agency.City);
            PerPhoneBox.Text = Convert.ToString(agency.Phone);
            PerPositionBox.Text = Convert.ToString(agency.Position);
            PerRateBox.Text = Convert.ToString(agency.Rate);
            AffiliationBox.Text = Convert.ToString(agency.AgencyId);
            AffiliationLabel.Text = "Agency ID";
            AgencyRadioButton.Checked = true;
        }

        public EditPersonnel(Outsourced outsourced)
        {
            InitializeComponent();

            PerIdBox.Text = Convert.ToString(outsourced.PersonnelId);
            PerNameBox.Text = outsourced.Name;
            PerCityBox.Text = Convert.ToString(outsourced.City);
            PerPhoneBox.Text = Convert.ToString(outsourced.Phone);
            PerPositionBox.Text = Convert.ToString(outsourced.Position);
            PerRateBox.Text = Convert.ToString(outsourced.Rate);
            AffiliationBox.Text = Convert.ToString(outsourced.AgencyContact);
            AffiliationLabel.Text = "Hiring Agency Contact";
            OutsourcedRadioButton.Checked = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (AgencyRadioButton.Checked)
            {
                AgencyRadioButton.Checked = true;

                if (String.IsNullOrWhiteSpace(PerIdBox.Text) || String.IsNullOrWhiteSpace(PerNameBox.Text) || String.IsNullOrWhiteSpace(PerCityBox.Text) || String.IsNullOrWhiteSpace(PerPhoneBox.Text) || String.IsNullOrWhiteSpace(PerPositionBox.Text) || String.IsNullOrWhiteSpace(PerRateBox.Text))
                {
                    MessageBox.Show("Fields cannot be empty.");
                    return;
                }

                if (int.Parse(PerIdBox.Text).GetType() != typeof(int))
                {
                    MessageBox.Show("Fields that require integers must contain integers.");
                    return;
                }

                if (decimal.Parse(PerRateBox.Text).GetType() != typeof(decimal))
                {
                    MessageBox.Show("Rate must be a decimal. Example: 0.00");
                    return;
                }

                else
                {
                    try
                    {
                        Agency agencyPersonnel = new Agency(int.Parse(PerIdBox.Text), PerNameBox.Text, PerCityBox.Text, PerPhoneBox.Text, PerPositionBox.Text, decimal.Parse(PerRateBox.Text), int.Parse(AffiliationBox.Text));
                        Inventory.UpdatePersonnel(int.Parse(PerIdBox.Text), agencyPersonnel);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Program Error.");
                        throw;
                    }
                    this.Close();

                }
            }
            else
            {
                AgencyRadioButton.Checked = false;

                if (String.IsNullOrWhiteSpace(PerIdBox.Text) || String.IsNullOrWhiteSpace(PerNameBox.Text) || String.IsNullOrWhiteSpace(PerCityBox.Text) || String.IsNullOrWhiteSpace(PerPhoneBox.Text) || String.IsNullOrWhiteSpace(PerPositionBox.Text) || String.IsNullOrWhiteSpace(PerRateBox.Text))
                {
                    MessageBox.Show("All fields must have a value.");
                    return;
                }

                if (int.Parse(PerIdBox.Text).GetType() != typeof(int) || int.Parse(PerPhoneBox.Text).GetType() != typeof(int))
                {
                    MessageBox.Show("Fields that require integers must contain integers.");
                    return;
                }

                if (decimal.Parse(PerRateBox.Text).GetType() != typeof(decimal))
                {
                    MessageBox.Show("Rate must be a decimal Example: 0.00.");
                    return;
                }
                else
                {
                    try
                    {
                        Outsourced outsourcedPersonnel = new Outsourced(int.Parse(PerIdBox.Text), PerNameBox.Text, PerCityBox.Text, PerPhoneBox.Text, PerPositionBox.Text, decimal.Parse(PerRateBox.Text), AffiliationBox.Text);
                        Inventory.UpdatePersonnel(int.Parse(PerIdBox.Text), outsourcedPersonnel);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Program Error.");
                        throw;
                    }
                    this.Close();
                }
            }
        }

        private void AgencyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AffiliationLabel.Text = "Agency ID";
        }

        private void OutsourcedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            AffiliationLabel.Text = "Hiring Agency Contact";
        }
    }
}
