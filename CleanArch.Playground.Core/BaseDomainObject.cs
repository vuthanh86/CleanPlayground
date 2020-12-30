using System;

namespace CleanArch.Playground.Core
{
    public abstract class BaseDomainObject
    {
        protected abstract Guid Id { get; set; }
    }
}