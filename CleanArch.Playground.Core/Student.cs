using System;

namespace CleanArch.Playground.Core
{
    public class Student : BaseDomainObject
    {
        #region Overrides of BaseDomainObject

        protected override Guid Id { get; set; }

        #endregion
    }
}