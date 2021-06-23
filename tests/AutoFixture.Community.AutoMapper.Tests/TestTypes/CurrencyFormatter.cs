using AutoMapper;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class CurrencyFormatter : IValueConverter<Dollars, string>
    {
        public string Convert(Dollars sourceMember, ResolutionContext context)
            => $"${(decimal) sourceMember:C}";
    }
}