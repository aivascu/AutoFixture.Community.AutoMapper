using AutoMapper;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class CurrencyFormatter : IValueConverter<Money, string>
    {
        public string Convert(Money sourceMember, ResolutionContext context)
        {
            return $"${(decimal)sourceMember:C}";
        }
    }
}
