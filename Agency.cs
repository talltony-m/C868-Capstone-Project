namespace C868
{
    public class Agency : Personnel

    {
        private int _agencyId;

        public int AgencyId
        {
            get { return _agencyId; }
            set { _agencyId = value; }
        }

        public Agency(int personnelId, string name, string city, string phone, string position, decimal rate)
        {
            PersonnelId = personnelId;
            Name = name;
            City = city;
            Phone = phone;
            Position = position;
            Rate = rate;
        }
        public Agency(int personnelId, string name, string city, string phone, string position, decimal rate, int agencyId)
        {
            PersonnelId = personnelId;
            Name = name;
            City = city;
            Phone = phone;
            Position = position;
            Rate = rate;
            AgencyId = agencyId;
        }
    }
}
