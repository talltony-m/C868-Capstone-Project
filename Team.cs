using System.ComponentModel;

namespace C868
{
    public class Team
    {
        private int _teamId;
        private string _name;
        private string _city;
        private string _phone;

        public BindingList<Personnel> AssociatedPersonnels = new BindingList<Personnel>();

        public int TeamId
        {
            get { return _teamId; }
            set { _teamId = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }

        public Team() { }

        public Team(int teamId, string name, string city, string phone)
        {
            _teamId = teamId;
            _name = name;
            _city = city;
            _phone = phone;
        }

        public void AddAssociatedPersonnel(Personnel personnel)
        {
            AssociatedPersonnels.Add(personnel);
        }

        public Personnel LookupAssociatePersonnel(int personnelId)
        {
            foreach (Personnel personnel in AssociatedPersonnels)
            {
                if (personnel.PersonnelId == personnelId)
                {
                    return personnel;
                }
            }
            return null;
        }

        public bool RemoveAssociatePersonnel(int personnelId)
        {
            {
                bool check = false;
                foreach (Personnel personnel in AssociatedPersonnels)
                {
                    if (personnel.PersonnelId == personnelId)
                    {
                        AssociatedPersonnels.Remove(personnel);
                        return check = true;
                    }
                    else check = false;
                }
                return check;
            }
        }
    }
}
