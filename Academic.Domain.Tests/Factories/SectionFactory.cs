﻿namespace Academic.Domain.Tests.Factories
{
    public class SectionFactory
    {
        public static Section Create()
        {
            return new Section(1, "TDD TEST");
        }
    }
}
