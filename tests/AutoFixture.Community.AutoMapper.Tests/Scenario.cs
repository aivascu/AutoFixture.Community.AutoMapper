using AutoFixture.Community.AutoMapper.Tests.TestTypes;
using AutoMapper;
using SemanticComparison.Fluent;
using Xunit;

namespace AutoFixture.Community.AutoMapper.Tests
{
    public class Scenario
    {
        [Fact]
        public void CreatesMapperInstance()
        {
            var fixture = new Fixture()
                .Customize(new AutoMapperCustomization());

            _ = fixture.Create<Mapper>();
        }

        [Fact]
        public void CreatesMapperInterfaceInstance()
        {
            var fixture = new Fixture()
                .Customize(new AutoMapperCustomization());

            _ = fixture.Create<IMapper>();
        }

        [Fact]
        public void CreatesExpectedMapperInterfaceInstanceType()
        {
            var fixture = new Fixture()
                .Customize(new AutoMapperCustomization());

            var mapper = fixture.Create<IMapper>();

            Assert.IsType<Mapper>(mapper);
        }

        [Fact]
        public void CanMapModels()
        {
            var fixture = new Fixture()
                .Customize(new AutoMapperCustomization(x => x
                    .AddProfile<AnemicModelProfile>()));
            var mapper = fixture.Create<IMapper>();
            var model = fixture.Create<AnemicModelDto>();

            var actual = mapper.Map<AnemicModel>(model);

            actual.AsSource().OfLikeness<AnemicModelDto>().ShouldEqual(model);
        }

        [Fact]
        public void CanMapModelsUsingTypeConverters()
        {
            var fixture = new Fixture()
                .Customize(new AutoMapperCustomization(x => x
                    .AddProfile<DomainModelProfile>()));
            var mapper = fixture.Create<IMapper>();
            var model = fixture.Create<FullNameDto>();

            var actual = mapper.Map<FullName>(model);

            actual.AsSource().OfLikeness<FullNameDto>().ShouldEqual(model);
        }

        [Fact]
        public void CanMapModelsUsingValueConverters()
        {
            var fixture = new Fixture()
                .Customize(new AutoMapperCustomization(x => x
                    .AddProfile<DomainModelProfile>()));
            var mapper = fixture.Create<IMapper>();
            var model = fixture.Create<FullNameDto>();

            var actual = mapper.Map<FullName>(model);

            actual.AsSource().OfLikeness<FullNameDto>().ShouldEqual(model);
        }

        [Fact]
        public void ServiceFactoryResolvesServiceFromAutoFixture()
        {
            var fixture = new Fixture()
                .Customize(new AutoMapperCustomization(x => x
                    .AddProfile<DomainModelProfile>()));
            var time = fixture.Freeze<ITime>(c => c
                .FromFactory<DelegatingTimeProvider>(x => x));
            var model = fixture.Create<OrderDto>();
            var expected = new Order(model.ProductId, model.Amount, time.Now);
            var mapper = fixture.Create<IMapper>();

            var actual = mapper.Map<Order>(model);

            actual.AsSource().OfLikeness<Order>().ShouldEqual(expected);
        }
    }
}
