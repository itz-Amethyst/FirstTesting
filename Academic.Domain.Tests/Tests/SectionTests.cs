namespace Academic.Domain.Tests.Tests
{
    public class SectionTests
    {

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
