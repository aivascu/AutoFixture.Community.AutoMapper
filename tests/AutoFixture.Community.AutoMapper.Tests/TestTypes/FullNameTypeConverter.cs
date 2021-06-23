using AutoMapper;

namespace AutoFixture.Community.AutoMapper.Tests.TestTypes
{
    public class FullNameTypeConverter: ITypeConverter<FullNameDto,FullName>
    {
        public FullName Convert(FullNameDto source, FullName destination, ResolutionContext context)
        {
            return new(source.FirstName, source.LastName);
        }
    }
}