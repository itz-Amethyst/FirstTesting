using Academic.Domain.Tests;

namespace Academic.Domain;

public class Course
{
    public int Id { get; set; }
    public string Name { get; set; }
    public bool IsOnline { get; set; }
    public double Tuition { get; set; }

    public List<Section> Sections { get; set; }

    public Course(int id, string name, bool isOnline, double tuition)
    {
        GuardAgainstInvalidName(name);

        GuardAgainstInvalidTuition();

        Id = id;
        Name = name;
        IsOnline = isOnline;
        Tuition = tuition;
    }
    private static void GuardAgainstInvalidName(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new CourseNameIsInvalidException();
        }
    }

    private void GuardAgainstInvalidTuition()
    {
        if (Tuition <= 0)
        {
            throw new CourseTuitionIsInvalid();
        }
    }

}