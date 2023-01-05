using System;
using AutoFixture.Kernel;
using AutoMapper;

#if !(NETSTANDARD2_1_OR_GREATER)
using AutoMapper.Configuration;
#endif

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
            fixture.Customizations.Add(new FixedTypeBuilder<Func<Type, object>>(
                type => new SpecimenContext(fixture).Resolve(type)));
            fixture.Customizations.Add(new TypeRelay<IMapper, Mapper>());
            fixture.Customizations.Add(new TypeRelay<IConfigurationProvider, MapperConfiguration>());
            fixture.Customize(new ConstructorCustomization(typeof(Mapper), new GreedyConstructorQuery()));
            fixture.Customize(SpecimenBuilderNodeFactory.CreateComposer<MapperConfigurationExpression>()
                .OmitAutoProperties().Do(this.configure).ToCustomization());
        }
    }
}
