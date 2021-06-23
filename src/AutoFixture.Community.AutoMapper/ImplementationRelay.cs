using AutoFixture.Kernel;

namespace AutoFixture.Community.AutoMapper
{
    internal class ImplementationRelay<TService, TImplementation> : TypeRelay
        where TImplementation : TService
    {
        public ImplementationRelay()
            : base(typeof(TService), typeof(TImplementation))
        {
        }
    }
}