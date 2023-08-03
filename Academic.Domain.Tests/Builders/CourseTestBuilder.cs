namespace Academic.Domain.Tests.Builders
{
    public class CourseTestBuilder
    {
        private const int Id = 1;

        private string _name = "Test";

        private const bool IsOnline = true;

        private double _tuition = 200;

        public CourseTestBuilder WithName(string name)
        {
            _name = name;
            return this;
        }

        public Course Build()
        {
            return new Course(Id, _name, IsOnline, _tuition);
        }

        public CourseTestBuilder WithTuition(double tuition)
        {
            _tuition = tuition;
            return this;
        }
    }
}
