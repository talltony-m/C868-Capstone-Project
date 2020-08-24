namespace C868
{
    public class Outsourced : Personnel

    {
        private string _agencyContact;

        public string AgencyContact
        {
            get { return _agencyContact; }
            set { _agencyContact = value; }
        }

        public Outsourced(int personnelId, string name, string city, string phone, string position, decimal rate)
        {
            PersonnelId = personnelId;
            Name = name;
            City = city;
            Phone = phone;
            Position = position;
            Rate = rate;
        }
        public Outsourced(int personnelId, string name, string city, string phone, string position, decimal rate, string agencyContact)
        {
            PersonnelId = personnelId;
            Name = name;
            City = city;
            Phone = phone;
            Position = position;
            Rate = rate;
            AgencyContact = agencyContact;
        }
    }
}
