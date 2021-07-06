# AutoFixture.Community.AutoMapper

[![GitHub Workflow Status](https://img.shields.io/github/workflow/status/aivascu/AutoFixture.Community.AutoMapper/release?logo=github&style=flat-square)](https://github.com/aivascu/AutoFixture.Community.AutoMapper/actions/workflows/release.yml)
[![GitHub](https://img.shields.io/github/license/aivascu/AutoFixture.Community.AutoMapper?style=flat-square)](https://licenses.nuget.org/MIT)
[![Nuget](https://img.shields.io/nuget/v/AutoFixture.Community.AutoMapper?logo=nuget&style=flat-square)](https://www.nuget.org/packages/AutoFixture.Community.AutoMapper/)

`AutoFixture.Community.AutoMapper` is a glue library that helps with integration of AutoFixture and AutoMapper.

## Features

The `AutoFixture.Community.AutoMapper` package offers a customization that helps

- Customizes AutoFixture to provide a fully configured `Mapper` instance
- Relays requests for an `IMapper` instance to the `Mapper` implementation
- Configures AutoMapper to use AutoFixture as a service factory
- Provides an easy way to include only the required AutoMapper configuration

## Examples

The example below demonstrates how to use the `AutoMapperCustomization` to integrate existing AutoMapper profiles.

```cs
public class ModelsProfile: Profile
{
    public ModelsProfile()
    {
        CreateMap<Customer, CustomerDto>();
    }
}

[Theory, AutoData]
public void MapsModels(Customer customer, Fixture fixture)
{
    // Arrange
    var expected = fixture.Build<CustomerDto>()
        .With(x => x.Id, customer.Id)
        .With(x => x.Name, customer.Name)
        .Create();

    fixture.Customize(new AutoMapperCustomization(x => x
        .AddMaps(typeof(ModelsProfile))));

    var sut = fixture.Create<IMapper>();

    // Act
    var actual = sut.Map<CustomerDto>(customer);

    // Assert
    actual.AsSource().OfLikeness<CustomerDto>()
        .ShouldEqual(expected);
}
```

## License

Copyright &copy; 2021 [Andrei Ivascu](https://github.com/aivascu).<br/>
This project is [MIT](https://github.com/aivascu/AutoFixture.Community.AutoMapper/blob/master/LICENSE) licensed.
