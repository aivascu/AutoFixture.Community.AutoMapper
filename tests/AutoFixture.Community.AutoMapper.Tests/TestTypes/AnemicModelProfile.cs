using AutoMapper;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class AnemicModelProfile : Profile
    {
        public AnemicModelProfile()
        {
            this.CreateMap<AnemicModel, AnemicModelDto>()
                .ReverseMap();
        }
    }
}
