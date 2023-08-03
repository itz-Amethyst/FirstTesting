using Academic.Domain.Exceptions;
using Academic.Domain.Tests.Builders;
using Academic.Domain.Tests.ClassFixtures;
using Academic.Domain.Tests.CollectionFixtures;
using Academic.Domain.Tests.Factories;

namespace Academic.Domain.Tests.Tests
{
    [Collection("Database Collection")]
    public class CourseTests : IClassFixture<IdentifierFixture>
    {
        private readonly CourseTestBuilder _courseTestBuilder;
        public CourseTests(DatabaseFixture databaseFixture)
        {
            _courseTestBuilder = new CourseTestBuilder();
        }

        [Fact]
        public void Constructor_ShouldConstructCourseProperly()
        {
            var guid = IdentifierFixture.Id;

            const int id = 1;

            const string name = "TDD Test Driven";

            const bool isOnline = true;

            const double tuition = 200;


            var course = _courseTestBuilder.Build();

            course.Id.Should().Be(id);
            course.Name.Should().Be(name);
            course.IsOnline.Should().Be(isOnline);
            course.Tuition.Should().Be(tuition);

            course.Sections.Should().beEmpty();

            //Assert.Equal(id, course.Id);

            //Assert.Equal(name, course.Name);

            //Assert.Equal(isOnline, course.IsOnline);

            //Assert.Equal(tuition, course.Tuition);
        }

        [Fact]
        public void Constructor_ShouldThrowException_when_NameIsNotProvided()
        {
            var guid = IdentifierFixture.Id;


            void Course() => _courseTestBuilder.WithName("").Build();

            //Assert.Throws<Exception>(Course);

            Course().Should.ThrowExactly<CourseNameIsInvalidException>();

        }

        [Fact]
        public void Constructor_ShouldThrowException_WhenTuitionIsNotProvided()
        {

            void Course() => _courseTestBuilder.WithTuition(0).Build();

            //Assert.Throws<Exception>(Course);

            Course().Should().ThrowExactly<CourseTuitionIsInvalidException>();
        }

        [Fact]
        public void AddSection_ShouldAddNewSectionToSections_When_IdAndName_Passed()
        {
            // Arrange
            var course = _courseTestBuilder.Build();

            var sectionToAdd = SectionFactory.Create();

            // Act

            course.AddSection(sectionToAdd);

            // Assert

            course.Sections.Should().ContainEquivalentOf(sectionToAdd);
        }
    }
}