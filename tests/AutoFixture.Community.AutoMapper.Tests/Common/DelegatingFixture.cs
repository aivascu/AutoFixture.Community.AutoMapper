using System;
using System.Collections.Generic;
using AutoFixture.Dsl;
using AutoFixture.Kernel;

namespace AutoFixture.Community.AutoMapper.Tests.Common
{
    public class DelegatingFixture : IFixture
    {
        public object Create(object request, ISpecimenContext context)
        {
            throw new NotImplementedException();
        }

        public ICustomizationComposer<T> Build<T>()
        {
            throw new NotImplementedException();
        }

        public IFixture Customize(ICustomization customization)
        {
            customization?.Customize(this);
            return this;
        }

        public void Customize<T>(Func<ICustomizationComposer<T>, ISpecimenBuilder> composerTransformation)
        {
            throw new NotImplementedException();
        }

        public IList<ISpecimenBuilder> Customizations { get; } = new List<ISpecimenBuilder>();

        public IList<ISpecimenBuilderTransformation> Behaviors { get; } = new List<ISpecimenBuilderTransformation>();

        public IList<ISpecimenBuilder> ResidueCollectors { get; } = new List<ISpecimenBuilder>();

        public bool OmitAutoProperties { get; set; }
        public int RepeatCount { get; set; }
    }
}
