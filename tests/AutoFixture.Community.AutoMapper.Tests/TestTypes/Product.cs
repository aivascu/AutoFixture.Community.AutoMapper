namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class Product
    {
        public Product(string name, Dollars price)
        {
            Name = name;
            Price = price;
        }

        public string Name { get; }
        public Dollars Price { get; }
    }
}