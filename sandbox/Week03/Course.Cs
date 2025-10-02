public class Course
{
    public string _courseName;
    public List<Students> _students = new List<Students>();

    public void DisplayCourseInfo()
    {
        Console.WriteLine($"Course Name: {_courseName}");
        foreach (Student s in _students)
        {
            s.DisplayName();
        }
    }
}