namespace DialogParameterDemo.Data
{
    public class Product
    {
        public string Id { get; }
        public string Name { get; }
        public int Price { get; }

        public Product(string id, string name, int price)
        {
            Id = id;
            Name = name;
            Price = price;
        }
    }
}