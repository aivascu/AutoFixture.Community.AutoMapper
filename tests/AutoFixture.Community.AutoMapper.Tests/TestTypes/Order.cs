using System;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class Order
    {
        public Guid ProductId { get; }
        public Dollars Amount { get; }

        public Order(Guid productId, Dollars amount)
        {
            ProductId = productId;
            Amount = amount;
        }
    }
}