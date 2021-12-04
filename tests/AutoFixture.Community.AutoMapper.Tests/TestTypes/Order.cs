using System;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class Order
    {
        public Order(Guid productId, Money amount, DateTime orderTime)
        {
            this.ProductId = productId;
            this.Amount = amount;
            this.OrderTime = orderTime;
        }

        public Guid ProductId { get; }
        public Money Amount { get; }
        public DateTime OrderTime { get; }
    }
}
