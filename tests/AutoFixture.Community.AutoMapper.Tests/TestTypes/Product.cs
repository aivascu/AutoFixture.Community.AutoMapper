namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class Product
    {
        public Product(string name, Money price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; }
        public Money Price { get; }
    }
}
