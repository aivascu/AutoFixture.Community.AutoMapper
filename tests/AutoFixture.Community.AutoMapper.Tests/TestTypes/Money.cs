using System;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class Money : IEquatable<Money>
    {
        private readonly decimal value;

        public Money(decimal value)
        {
            this.value = value;
        }

        public override bool Equals(object obj)
        {
            return this.Equals(obj as Money);
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(this.value);
        }

        public bool Equals(Money other)
        {
            return !(other is null)
                   && other.value == this.value;
        }

        public static implicit operator decimal(Money money)
        {
            return money.value;
        }

        public static implicit operator Money(decimal value)
        {
            return new Money(value);
        }

        public static bool operator ==(Money left, Money right)
        {
            return Equals(left, right);
        }

        public static bool operator !=(Money left, Money right)
        {
            return !Equals(left, right);
        }
    }
}
