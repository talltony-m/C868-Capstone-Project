using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace C868
{
    public class Inventory : IDisposable
    {
        FileStream newFile;

        public void HasDisposeMethod() => newFile = new FileStream(@"c:\temp.txt", FileMode.Open);

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                newFile.Close();
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }


        public static BindingList<Team> Teams = new BindingList<Team>();
        public static BindingList<Personnel> Personnels = new BindingList<Personnel>();

        public static int personnelIndex;
        public static void AddTeam(Team team)
        {
            Teams.Add(team);
        }


        public static bool RemoveTeam(int teamId)
        {
            bool check = false;
            foreach (Team t in Teams)
            {
                if (teamId == t.TeamId)
                {
                    Teams.Remove(t);
                    check = true;
                }
                else
                {
                    MessageBox.Show("Team does not Exist.");
                    check = false;
                }
            }
            return check;
        }

        public static Team LookupTeam(int teamId)
        {
            foreach (Team t in Teams)
            {
                if (t.TeamId == teamId)
                {
                    return t;
                }
            }
            return null;
        }

        public static void UpdateTeam(int teamId, Team team)
        {
            foreach (Team t in Teams)
            {
                if (teamId == t.TeamId)
                {
                    t.Name = team.Name;
                    t.City = team.City;
                    t.Phone = team.Phone;
                    return;
                }
            }
        }

        public static void AddPersonnel(Personnel personnel)
        {
            Personnels.Add(personnel);
        }

        public static bool DeletePersonnel(Personnel personnel)
        {
            bool check = false;
            foreach (Personnel p in Personnels)
            {
                if (p.PersonnelId == personnel.PersonnelId)
                {
                    Personnels.Remove(p);
                    check = true;
                }
                else
                {
                    MessageBox.Show("Personnel does not Exist");
                    check = false;
                }
            }
            return check;
        }

        public static Personnel LookupPersonnel(int personnelId)
        {
            foreach (Personnel p in Personnels)
            {
                if (p.PersonnelId == personnelId)
                {
                    return p;
                }
            }
            return null;
        }

        public static void UpdatePersonnel(int personnelId, Personnel personnel)
        {
            Inventory.Personnels.RemoveAt(Inventory.personnelIndex);
            Inventory.Personnels.Add(personnel);
        }
    }
}
