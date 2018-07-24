namespace challenge
{
    class Product
    {
        private string sku;
        private string name;
        private string description;

        public Product(string sku, string name, string description)
        {
            this.sku = sku;
            this.name = name;
            this.description = description;
        }

        public string Sku{set; get;}
        public string Name{set; get;}
        public string Descrption{set; get;}
    }
}