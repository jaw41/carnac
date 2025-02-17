﻿using Xunit;

namespace Carnac.Tests
{
    public abstract class SpecificationFor<T>
    {
        public T Subject;

        public abstract T Given();

        [Fact]
        public abstract void When();

        protected SpecificationFor()
        {
            Subject = Given();
            When();
        }
    }
}
