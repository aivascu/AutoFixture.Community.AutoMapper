using AutoMapper;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class AnemicModelProfile : Profile
    {
        public AnemicModelProfile()
        {
            CreateMap<AnemicModel, AnemicModelDto>()
                .ReverseMap();
        }
    }
}