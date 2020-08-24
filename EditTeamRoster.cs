using System;
using System.Windows.Forms;

namespace C868
{
    public partial class EditTeamRoster : Form
    {
        public EditTeamRoster(Team team)
        {
            InitializeComponent();


            TeamIdBox.Text = Convert.ToString(team.TeamId);
            TeamNameBox.Text = team.Name;
            TeamCityBox.Text = Convert.ToString(team.City);
            TeamPhoneBox.Text = Convert.ToString(team.Phone);

            DgCanPersonnel.DataSource = Inventory.Personnels;
            DgAssigTeam.DataSource = team.AssociatedPersonnels;
        }

        private void EditTeamRoster_Load(object sender, EventArgs e)
        {

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (SearchBox.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in DgCanPersonnel.Rows)
                    {
                        Personnel personnel = (Personnel)row.DataBoundItem;
                        Personnel userEntry = Inventory.LookupPersonnel(Convert.ToInt32(SearchBox.Text));

                        if (userEntry.PersonnelId == personnel.PersonnelId)
                        {
                            row.Selected = true;
                            DgCanPersonnel.CurrentCell = row.Cells[0];
                            return;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
                catch { }
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int teamId = Convert.ToInt32(TeamIdBox.Text);
            int personnelId = Convert.ToInt32(DgCanPersonnel.Rows[DgCanPersonnel.CurrentCell.RowIndex].Cells[0].Value);
            Team team = Inventory.LookupTeam(teamId);
            Personnel personnel = Inventory.LookupPersonnel(personnelId);
            Inventory.UpdateTeam(teamId, team);
            team.AddAssociatedPersonnel(personnel);
            DgAssigTeam.DataSource = team.AssociatedPersonnels;
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Confirm Delete.", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    var rowIndex = DgAssigTeam.CurrentCell.RowIndex;
                    DgAssigTeam.Rows.RemoveAt(rowIndex);
                }
                else return;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
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
                    try
                    {
                        foreach (DataGridViewRow row in DgAssigTeam.Rows)
                        {
                            Personnel associatedPersonnel = (Personnel)row.DataBoundItem;
                            team.AssociatedPersonnels.Add(associatedPersonnel);
                        }
                    }
                    catch { throw; }
                    Inventory.UpdateTeam(int.Parse(TeamIdBox.Text), team);
                }
                catch (Exception)
                {
                    MessageBox.Show("Program Error.");
                    throw;
                }
                this.Close();
            }
        }

        private void TeamIdBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamCityBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamPhoneBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgCanPersonnel_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgAssigTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
