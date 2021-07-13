using System;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class Order
    {
        public Order(Guid productId, Money amount)
        {
            this.ProductId = productId;
            this.Amount = amount;
        }

        public Guid ProductId { get; }
        public Money Amount { get; }
    }
}
