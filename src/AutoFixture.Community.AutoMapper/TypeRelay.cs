using AutoFixture.Kernel;

namespace AutoFixture.Community.AutoMapper
{
    internal class TypeRelay<TService, TImplementation> : TypeRelay
        where TImplementation : TService
    {
        public TypeRelay()
            : base(typeof(TService), typeof(TImplementation))
        {
        }
    }
}
