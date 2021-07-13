using System;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class FullName
    {
        public FullName(string firstName, string lastName)
        {
            this.FirstName = firstName ?? throw new ArgumentNullException(nameof(firstName));
            this.LastName = lastName ?? throw new ArgumentNullException(nameof(lastName));
        }

        public string FirstName { get; }
        public string LastName { get; }
    }
}
