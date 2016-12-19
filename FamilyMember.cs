using System;
using System.Collections.Generic;
using Family.Common;

namespace ConsoleFamily
{
    class FamilyMember
    {
        private readonly ChainElement components;

        public FamilyMember(ChainElement components)
        {
            this.components = components;
        }

        public T As<T>(T defaultValue) where T : class
        {
            return this.components.As<T>(defaultValue);
        }
    }
}