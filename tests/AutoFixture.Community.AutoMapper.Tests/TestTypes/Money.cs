namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class Money
    {
        private readonly decimal value;

        public Money(decimal value)
        {
            this.value = value;
        }

        public static implicit operator decimal(Money money)
        {
            return money.value;
        }

        public static implicit operator Money(decimal value)
        {
            return new Money(value);
        }
    }
}
