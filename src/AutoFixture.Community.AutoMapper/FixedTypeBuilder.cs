using AutoFixture.Kernel;

namespace AutoFixture.Community.AutoMapper
{
    internal class FixedTypeBuilder<T> : FilteringSpecimenBuilder
    {
        public FixedTypeBuilder(T value)
            :base(
                new FixedBuilder(value),
                new ExactTypeSpecification(typeof(T)))
        {
        }
    }
}