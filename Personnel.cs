namespace C868
{
    public abstract class Personnel
    {
        private int _personnelId;
        private string _name;
        private string _city;
        private string _phone;
        private string _position;
        private decimal _rate;



        public int PersonnelId
        {
            get { return _personnelId; }
            set { _personnelId = value; }
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
        public string Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public decimal Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

    }
}
