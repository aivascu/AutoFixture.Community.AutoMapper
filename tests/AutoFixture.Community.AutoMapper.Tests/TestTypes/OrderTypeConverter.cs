using AutoMapper;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class OrderTypeConverter : ITypeConverter<OrderDto, Order>
    {
        private readonly ITime time;

        public OrderTypeConverter(ITime time)
        {
            this.time = time;
        }

        public Order Convert(OrderDto source, Order destination, ResolutionContext context)
        {
            return new Order(source.ProductId, source.Amount, this.time.Now);
        }
    }
}
