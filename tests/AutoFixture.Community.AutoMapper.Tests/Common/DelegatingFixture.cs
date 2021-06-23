using System;
using System.Collections.Generic;
using AutoFixture.Dsl;
using AutoFixture.Kernel;

namespace AutoFixture.Community.AutoMapper.Tests.Common
{
    public class DelegatingFixture : IFixture
    {
        private readonly IList<ISpecimenBuilder> customizations = new List<ISpecimenBuilder>();
        private readonly IList<ISpecimenBuilderTransformation> behaviors = new List<ISpecimenBuilderTransformation>();
        private readonly IList<ISpecimenBuilder> residueCollectors = new List<ISpecimenBuilder>();

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

        public IList<ISpecimenBuilder> Customizations => customizations;
        public IList<ISpecimenBuilderTransformation> Behaviors => behaviors;
        public IList<ISpecimenBuilder> ResidueCollectors => residueCollectors;

        public bool OmitAutoProperties { get; set; }
        public int RepeatCount { get; set; }
    }
}