using AutoMapper;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class DomainModelProfile : Profile
    {
        public DomainModelProfile()
        {
            this.CreateMap<FullNameDto, FullName>()
                .ConvertUsing<FullNameTypeConverter>();

            this.CreateMap<Product, ProductDto>()
                .ForMember(x => x.Price, o => o.ConvertUsing<CurrencyFormatter, Money>());

            this.CreateMap<OrderDto, Order>()
                .ConvertUsing<OrderTypeConverter>();
        }
    }
}
