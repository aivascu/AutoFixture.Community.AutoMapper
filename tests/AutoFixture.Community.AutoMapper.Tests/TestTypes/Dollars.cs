namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class Dollars
    {
        private readonly decimal value;

        public Dollars(decimal value)
        {
            this.value = value;
        }

        public static implicit operator decimal(Dollars money)
            => money.value;

        public static implicit operator Dollars(decimal value)
            => new Dollars(value);
    }
}