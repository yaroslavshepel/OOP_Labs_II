namespace Lab3;

public class StudentArr
{
    public StudentArr() { }
    private static int _studentNumber;
    public static Student[] _StudentsArr;
    
    public static Student AddStudent(string firstName, string lastName, int course, string studentId, string genderType, double averageGrade, string identificationCode)
    {
        return new Student(firstName, lastName, course, studentId, genderType, averageGrade, identificationCode);
    }
    
    public static void SetNumberOfStudents(int studentNumber)
    {
        _studentNumber = studentNumber;
        _StudentsArr = new Student[_studentNumber];
    }
    
    public static int GetNumberOfStudents()
    {
        return _studentNumber;
    }
    
    public static Student FindStudent (string studentId)
    {
        foreach (var student in _StudentsArr)
        {
            if (student.StudentID == studentId)
            {
                return student;
            }
        }
        return null;
    }
}