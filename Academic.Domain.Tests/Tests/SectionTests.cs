﻿using Academic.Domain.Tests.CollectionFixtures;

namespace Academic.Domain.Tests.Tests
{
    [Collection("Database Collection")]
    public class SectionTests
    {
        public SectionTests(DatabaseFixture databaseFixture)
        {
            
        }


        [Fact]
        public void Constructor_ShouldConstruct_Section_Properly()
        {
            //Arrange -> Setup
            const int id = 1;

            const string name = "Tdd Section";

            //Act -> Exercise

            var section = new Section(id, name);


            //Assert -> Verify

            section.Id.Should().Be(id);
            section.Name.Should().Be(name);

        }
    }
}
