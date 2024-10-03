namespace Lab3;

//[AttributeFirstName("Unknown")]
[AttributeFirstName]
[AttributeLastName("Unknown")]
public class Student
{
    private string _surname;
    private string _name;
    private int _course;
    private string _studentId;
    private enum _sex { male, female }
    private double _averageMark;
    private int _idNumber;
    
    Student()
    {
        _surname = "Unknown";
        _name = "Unknown";
        _course = 0;
        _studentId = "Unknown";
        _averageMark = 0;
        _idNumber = 0;
    } // default constructor
    
    Student(string surname, string name, int course, string studentId, double averageMark, int idNumber)
    {
        _surname = surname;
       // _name = name;
        _name = name;
        _course = course;
        _studentId = studentId;
        _averageMark = averageMark;
        _idNumber = idNumber;
    }
}