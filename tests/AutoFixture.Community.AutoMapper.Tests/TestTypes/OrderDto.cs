using System;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class OrderDto
    {
        public Guid ProductId { get; set; }
        public decimal Amount { get; set; }
        public DateTime OrderTime { get; set; }
    }
}