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
    }

    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsOnline { get; set; }
        public double Tuition { get; set; }

        public Course(int id, string name, bool isOnline, double tuition)
        {
            Id = id;
            Name = name;
            IsOnline = isOnline;
            Tuition = tuition;
        }

     
    }
}