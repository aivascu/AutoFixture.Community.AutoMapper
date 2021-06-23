using AutoMapper;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class DomainModelProfile : Profile
    {
        public DomainModelProfile()
        {
            CreateMap<FullNameDto, FullName>()
                .ConvertUsing<FullNameTypeConverter>();

            CreateMap<Product, ProductDto>()
                .ForMember(x => x.Price, o => o.ConvertUsing<CurrencyFormatter, Dollars>());
        }
    }
}