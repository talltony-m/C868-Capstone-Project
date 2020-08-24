using System;
using System.Windows.Forms;


namespace C868
{
    public partial class MainRoster : Form
    {
        Team team = new Team();
        public MainRoster()
        {
            InitializeComponent();
            InitializeTeamsAndPersonnel();
            RefreshGridViews();
        }
        public void MainRoster_Load(object sender, EventArgs e)
        {
            RefreshGridViews();
        }

        public static void InitializeTeamsAndPersonnel()
        {
            Inventory.Teams.Add(new Team(001, "NW Team 1", "Chelan", "509-423-6233"));
            Inventory.Teams.Add(new Team(002, "NW Team 2", "Spokane", "509-555-1212"));
            Inventory.Teams.Add(new Team(010, "R6 Team 10", "Seattle", "206-555-1213"));
            Inventory.Teams.Add(new Team(011, "R6 Team 11", "Portland", "503-555-1234"));

            Inventory.Personnels.Add(new Agency(100, "Tony Martin", "Chelan", "509-423-6233", "ICT3", 60, 01));
            Inventory.Personnels.Add(new Agency(105, "Bill McGrath", "Spokane", "509-555-1212", "ICT3", 55, 02));
            Inventory.Personnels.Add(new Agency(200, "John Doe", "Seattle", "206-555-1213", "ICT2", 80, 01));
            Inventory.Personnels.Add(new Agency(205, "Jim Smith", "Portland", "502-555-1234", "ICT2", 75, 02));

            Inventory.Personnels.Add(new Outsourced(911, "Justin Jackson", "Richland", "509-555-1235", "HEQB", 30, "Corso"));
            Inventory.Personnels.Add(new Outsourced(912, "Amy Smart", "Grand Coulee", "509-555-1236", "EMT2", 25, "Corso"));
            Inventory.Personnels.Add(new Outsourced(913, "Andy Glidwell", "Prineville", "503-555-1237", "FFT1", 35, "Corso"));

            Inventory.LookupTeam(001).AddAssociatedPersonnel(Inventory.LookupPersonnel(100));
            Inventory.LookupTeam(001).AddAssociatedPersonnel(Inventory.LookupPersonnel(200));
            Inventory.LookupTeam(001).AddAssociatedPersonnel(Inventory.LookupPersonnel(911));
            Inventory.LookupTeam(001).AddAssociatedPersonnel(Inventory.LookupPersonnel(912));
            Inventory.LookupTeam(001).AddAssociatedPersonnel(Inventory.LookupPersonnel(913));

            Inventory.LookupTeam(002).AddAssociatedPersonnel(Inventory.LookupPersonnel(105));
            Inventory.LookupTeam(002).AddAssociatedPersonnel(Inventory.LookupPersonnel(205));
            Inventory.LookupTeam(002).AddAssociatedPersonnel(Inventory.LookupPersonnel(911));
            Inventory.LookupTeam(002).AddAssociatedPersonnel(Inventory.LookupPersonnel(912));
            Inventory.LookupTeam(002).AddAssociatedPersonnel(Inventory.LookupPersonnel(913));

            Inventory.LookupTeam(010).AddAssociatedPersonnel(Inventory.LookupPersonnel(100));
            Inventory.LookupTeam(010).AddAssociatedPersonnel(Inventory.LookupPersonnel(200));
            Inventory.LookupTeam(010).AddAssociatedPersonnel(Inventory.LookupPersonnel(911));
            Inventory.LookupTeam(010).AddAssociatedPersonnel(Inventory.LookupPersonnel(912));
            Inventory.LookupTeam(010).AddAssociatedPersonnel(Inventory.LookupPersonnel(913));

            Inventory.LookupTeam(011).AddAssociatedPersonnel(Inventory.LookupPersonnel(105));
            Inventory.LookupTeam(011).AddAssociatedPersonnel(Inventory.LookupPersonnel(205));
            Inventory.LookupTeam(011).AddAssociatedPersonnel(Inventory.LookupPersonnel(911));
            Inventory.LookupTeam(011).AddAssociatedPersonnel(Inventory.LookupPersonnel(912));
            Inventory.LookupTeam(011).AddAssociatedPersonnel(Inventory.LookupPersonnel(913));
        }
        public static int EditPersonnelIndex { get; set; }

        public void RefreshGridViews()
        {
            DgPer.DataSource = Inventory.Personnels;
            DgPer.ClearSelection();

            DgTeam.DataSource = Inventory.Teams;
            DgTeam.ClearSelection();
        }

        private void PerSearchButton_Click(object sender, EventArgs e)
        {
            if (PerSearchBox.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in DgPer.Rows)
                    {
                        Personnel personnel = (Personnel)row.DataBoundItem;
                        Personnel userEntry = Inventory.LookupPersonnel(Convert.ToInt32(PerSearchBox.Text));

                        if (userEntry.PersonnelId == personnel?.PersonnelId)
                        {
                            row.Selected = true;
                            DgPer.CurrentCell = row.Cells[0];
                            return;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
                catch
                {

                }
            }
        }


        private void PerAddButton_Click(object sender, EventArgs e)
        {
            AddPersonnel addPersonnelForm = new AddPersonnel();
            addPersonnelForm.Show();
        }

        private void PerEditButton_Click(object sender, EventArgs e)
        {
            if (DgPer.CurrentRow.DataBoundItem.GetType() == typeof(Agency))
            {
                Agency agencyPersonnel = (Agency)DgPer.CurrentRow.DataBoundItem;
                new EditPersonnel(agencyPersonnel).ShowDialog();
            }
            else if (DgPer.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
            {
                Outsourced outsourcedPersonnel = (Outsourced)DgPer.CurrentRow.DataBoundItem;
                new EditPersonnel(outsourcedPersonnel).ShowDialog();
            }
        }

        private void PerDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Delete?", MessageBoxButtons.OKCancel);
            {
                if (confirm == DialogResult.OK)
                {
                    var rowIndex = DgPer.CurrentCell.RowIndex;
                    DgPer.Rows.RemoveAt(rowIndex);
                    team.RemoveAssociatePersonnel(rowIndex);
                }
                else return;
            }
        }

        private void TeamSearchButton_Click(object sender, EventArgs e)
        {
            if (TeamSearchBox.TextLength < 0)
            {
                return;
            }
            else
            {
                try
                {
                    foreach (DataGridViewRow row in DgTeam.Rows)
                    {
                        Team Team = (Team)row.DataBoundItem;
                        Team userEntry = Inventory.LookupTeam(Convert.ToInt32(TeamSearchBox.Text));

                        if (userEntry.TeamId == Team?.TeamId)
                        {
                            row.Selected = true;
                            DgTeam.CurrentCell = row.Cells[0];
                            return;
                        }
                        else
                        {
                            row.Selected = false;
                        }
                    }
                }
                catch
                {
                }
            }
        }

        private void TeamAddButton_Click(object sender, EventArgs e)
        {
            new AddTeamRoster().ShowDialog();
        }

        private void TeamEditButton_Click(object sender, EventArgs e)
        {
            Team team = (Team)DgTeam.CurrentRow.DataBoundItem;
            new EditTeamRoster(team).ShowDialog();
        }

        private void TeamDeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete?", "Delete?", MessageBoxButtons.OKCancel);
            if (confirm == DialogResult.OK)
            {
                Team team = (Team)DgTeam.CurrentRow.DataBoundItem;
                if (team.AssociatedPersonnels.Count > 0)
                {
                    MessageBox.Show("Remove Associated Personnel before removing a Team.");
                }
                else
                {
                    var rowIndex = DgTeam.CurrentCell.RowIndex;
                    DgTeam.Rows.RemoveAt(rowIndex);
                }
            }
            else return;
        }

        private void PerSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TeamSearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void DgPer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgTeam_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Inventory.personnelIndex = DgPer.CurrentCell.RowIndex;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void PerSearchBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
