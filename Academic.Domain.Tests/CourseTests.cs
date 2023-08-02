namespace Academic.Domain.Tests
{
    public class CourseTests
    {
        [Fact]
        public void Constructor_ShouldConstructCourseProperly()
        {
            const int id = 1;

            const string name = "TDD Test Driven";

            const bool isOnline = true;

            const double tuition = 200;

            var courseBuilder = new CourseTestBuilder();

            var course = courseBuilder.Build();

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
            var courseBuilder = new CourseTestBuilder();

            void Course() => courseBuilder.WithName("").Build();

            //Assert.Throws<Exception>(Course);

            Course().Should.ThrowExactly<CourseNameIsInvalidException>();

        }

        [Fact]
        public void Constructor_ShouldThrowException_WhenTuitionIsNotProvided()
        {
            var courseBuilder = new CourseTestBuilder();

            void Course() => courseBuilder.WithTuition(0).Build();

            //Assert.Throws<Exception>(Course);

            Course().Should().ThrowExactly<CourseTuitionIsInvalid>();
        }

        [Fact]
        public void AddSection_ShouldAddNewSectionToSections_When_IdAndName_Passed()
        {
            // Arrange
            var courseBuilder = new CourseTestBuilder();
            var course = courseBuilder.Build();

            var sectionToAdd = SectionFactory.Create();

            // Act

            course.AddSection(sectionToAdd);

            // Assert

            course.Sections.Should().ContainEquivalentOf(sectionToAdd);
        }
    }
}