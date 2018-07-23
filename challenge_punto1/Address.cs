namespace challenge
{
    class Address
    {
        private int id;
        private string lineOne;
        private string lineTwo;
        private string city;
        private string country;
        private bool billingAddress;

        public string getAddress()
        {
            return $"{this.lineOne} {this.lineTwo}, {this.city} ({this.country})";
        }
    }
}
