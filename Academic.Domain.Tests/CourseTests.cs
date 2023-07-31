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

            var course = new Course(id , name , isOnline , tuition);

            Assert.Equal(id, course.Id);

            Assert.Equal(name, course.Name);

            Assert.Equal(isOnline, course.IsOnline);

            Assert.Equal(tuition, course.Tuition);
        }

        [Fact]
        public void Constructor_ShouldThrowException_when_NameIsNotProvided()
        {
            const int id = 1;

            const string name = "";

            const bool isOnline = true;

            const double tuition = 200;

            void course() => new Course(id, name, isOnline, tuition);

            Assert.Throws<Exception>(course);

        }

        [Fact]
        public void Constructor_ShouldThrowException_WhenTuitionIsNotProvided()
        {
            const int id = 1;

            const string name = "TDD Test Driven";

            const bool isOnline = true;

            const double tuition = 0;

            void course() => new Course(id, name, isOnline, tuition);

            Assert.Throws<Exception>(course);
        }
    }
}