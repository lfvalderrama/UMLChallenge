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

        public Address(string lineOne, string lineTwo, string city, string country, bool billingAddress)
        {
            this.LineOne = lineOne;
            this.LineTwo = lineTwo;
            this.City = city;
            this.Country = country;
            this.BillingAddress = billingAddress;
        }

        public int Id { get => id; set => id = value; }
        public string LineOne { get => lineOne; set => lineOne = value; }
        public string LineTwo { get => lineTwo; set => lineTwo = value; }
        public string City { get => city; set => city = value; }
        public string Country { get => country; set => country = value; }
        public bool BillingAddress { get => billingAddress; set => billingAddress = value; }

        public string getAddress()
        {
            return $"{this.LineOne} {this.LineTwo}, {this.City} ({this.Country})";
        }
    }
}
