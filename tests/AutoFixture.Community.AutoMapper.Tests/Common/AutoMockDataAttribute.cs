using AutoFixture.AutoMoq;
using AutoFixture.Xunit2;

namespace AutoFixture.Community.AutoMapper.Tests.Common
{
    public class AutoMockDataAttribute : AutoDataAttribute
    {
        public AutoMockDataAttribute()
            : base(() => new Fixture()
                .Customize(new AutoMoqCustomization()))
        {
        }
    }
}
