namespace CourseIO.Entities
{
    internal class Product
    {
        public String Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double TotalValue()
        {
            return Price * Quantity;
        }

    }
}
