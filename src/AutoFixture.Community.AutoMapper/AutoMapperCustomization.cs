using System;
using AutoFixture.Kernel;
using AutoMapper;
using AutoMapper.Configuration;

namespace AutoFixture.Community.AutoMapper
{
    public class AutoMapperCustomization : ICustomization
    {
        private readonly Action<IMapperConfigurationExpression> configure;

        public AutoMapperCustomization(Action<IMapperConfigurationExpression> configure = default)
        {
            this.configure = x => configure?.Invoke(x);
        }

        public void Customize(IFixture fixture)
        {
            fixture.Customizations.Add(
                new FixedTypeBuilder<Func<Type, object>>(
                    t => new SpecimenContext(fixture).Resolve(t)));
            fixture.Customizations.Add(new ImplementationRelay<IMapper, Mapper>());
            fixture.Customizations.Add(new ImplementationRelay<IConfigurationProvider, MapperConfiguration>());
            new ConstructorCustomization(typeof(Mapper), new GreedyConstructorQuery())
                .Customize(fixture);
            SpecimenBuilderNodeFactory
                .CreateComposer<MapperConfigurationExpression>()
                .OmitAutoProperties()
                .Do(configure)
                .ToCustomization()
                .Customize(fixture);
        }
    }
}