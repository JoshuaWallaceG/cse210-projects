public class Student
{
    public string _firstName;
    public string _lastName;
    public string _id;

    public void DisplayName()
    {
        Console.WriteLine($"{_firstName} {_lastName}");
    }
    public void DisplayInfo()
    {
        Console.WriteLine("Student Info:");
        Console.WriteLine($"    {_firstName} {_lastName}");
        Console.WriteLine($"    {_id}");
    }
}