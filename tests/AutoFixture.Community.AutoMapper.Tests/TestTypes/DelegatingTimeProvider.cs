using System;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class DelegatingTimeProvider : ITime
    {
        public DateTime Now { get; set; }
    }
}
