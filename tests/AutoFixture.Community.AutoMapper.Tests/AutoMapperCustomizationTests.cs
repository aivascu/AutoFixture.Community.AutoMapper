using AutoFixture.Community.AutoMapper.Tests.Common;
using AutoFixture.Kernel;
using AutoMapper;
using Xunit;

namespace AutoFixture.Community.AutoMapper.Tests
{
    public class AutoMapperCustomizationTests
    {
        [Fact]
        public void CanCreateInstance()
        {
            _ = new AutoMapperCustomization();
        }

        [Fact]
        public void IsCustomizationType()
        {
            var sut = new AutoMapperCustomization();

            Assert.IsAssignableFrom<ICustomization>(sut);
        }

        [Fact]
        public void AddsMapperRelay()
        {
            var fixture = new DelegatingFixture();
            var sut = new AutoMapperCustomization();

            sut.Customize(fixture);

            Assert.Contains(
                fixture.Customizations,
                x => x is TypeRelay relay
                     && relay.From == typeof(IMapper)
                     && relay.To == typeof(Mapper));
        }

        [Fact]
        public void AddsConfigurationRelay()
        {
            var fixture = new DelegatingFixture();
            var sut = new AutoMapperCustomization();

            sut.Customize(fixture);

            Assert.Contains(
                fixture.Customizations,
                x => x is TypeRelay relay
                     && relay.From == typeof(IConfigurationProvider)
                     && relay.To == typeof(MapperConfiguration));
        }
    }
}
