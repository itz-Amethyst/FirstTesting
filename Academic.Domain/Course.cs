using Academic.Domain.Exceptions;

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
        Sections = new List<Section>();
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
            throw new CourseTuitionIsInvalidException();
        }
    }

    public void AddSection(Section section)
    {
        Sections.Add(section);
    }
}