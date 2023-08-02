namespace Academic.Domain.Tests
{
    public class CourseTestBuilder
    {
        int id = 1;

        string name = "Test";

        bool isOnline = true;

        double tuition = 200;

        public CourseTestBuilder WithName(string name)
        {
            this.name = name;
            return this;
        }

        public Course Build()
        {
            return new Course(id, name, isOnline, tuition);
        }
    }
}
