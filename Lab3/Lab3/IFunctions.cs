using System.Text.Json;
namespace Lab3;

public interface IFunctions
{
    static async Task ReadData(int num)
    {
        var options = new JsonSerializerOptions { WriteIndented = true };
        await using (FileStream fs = new FileStream("Students.json", FileMode.Open))
        {
            var loadedData = await JsonSerializer.DeserializeAsync<StudentData>(fs, options);

            StudentArr.SetNumberOfStudents(loadedData.NumberOfStudents);
            
            for (int i = 0; i < loadedData.Students.Length; i++)
            {
                StudentArr._StudentsArr[i] = loadedData.Students[i];
            }
            if (num == 1)
            {
                Console.WriteLine($"Number of dishes: {loadedData.NumberOfStudents}");
                foreach (var student in loadedData.Students)
                {
                        
                    Console.WriteLine(student.DisplayStudent(student));
                }
            }
        }
    }
    
    static string InputCheck(string typeOfInput)
    {
        decimal amount;
        switch (typeOfInput)
        {
            case "Menu":
                var choice = -1;
                try { choice = Convert.ToInt32(Console.ReadLine()); }
                catch (FormatException)
                {
                    throw new CustomException("Invalid input format. Please enter a number.");
                }
                catch (Exception ex)
                {
                    throw new CustomException("An unexpected error occurred.", ex);
                }
                Console.WriteLine(ConsoleMenu.PrintLongThing());
                return Convert.ToString(choice); 
                break;
            case "Input":
                int input = 0;
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("This must be an integer. Please enter a valid integer.");
                }

                return Convert.ToString(input);
                break;
        }
        return "";
    }

    static async Task RemoveStudentFromFile()
    {
        Console.WriteLine("Enter the StudentID of the student you want to remove:");
        string Id = Console.ReadLine();
        string message = "";
        var studentToRemove = StudentArr.FindStudent(Id);
        if (studentToRemove == null)
        {
            Console.WriteLine(message);
            return;
        }

        var updatedStudents = new Student[StudentArr.GetNumberOfStudents() - 1];
        int j = 0;
        for (int i = 0; i < StudentArr.GetNumberOfStudents(); i++)
        {
            if (StudentArr._StudentsArr[i].StudentID == Id)
            {
                continue;
            }
            updatedStudents[j] = StudentArr._StudentsArr[i];
            j++;
        }

        StudentArr.SetNumberOfStudents(StudentArr.GetNumberOfStudents() - 1);
        StudentArr._StudentsArr = updatedStudents;

        await SaveStudentsToFile();
    }
    
    static async Task AddNewStudentToFile()
    {
        var options = new JsonSerializerOptions { WriteIndented = true };

        StudentData existingData;
        if (File.Exists("Students.json"))
        {
            using (FileStream fs = new FileStream("Students.json", FileMode.Open))
            {
                existingData = await JsonSerializer.DeserializeAsync<StudentData>(fs, options);
            }
        }
        else
        {
            existingData = new StudentData { NumberOfStudents = 0, Students = new Student[0] };
        }

        Console.WriteLine("Enter the first name of the new student:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter the last name of the new student:");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter the course of the new student:");
        int course;
        while (true)
        {
            course = Convert.ToInt32(InputCheck("Input"));
            if (!(course >= 1 && course <= 5))
            { Console.WriteLine("Course must be between 1 and 5. Please enter a valid course:"); }
            else { break; }
        }
        Console.WriteLine("Enter student ID:");
        string studentId = Console.ReadLine();
        Console.WriteLine($"Enter the gender of the new student (choose from Male = 0,Female = 1):");
        int studentGender;
        while (true)
        {
            studentGender = Convert.ToInt32(InputCheck("Input"));
            if (!Enum.IsDefined(typeof(Student.Gender), studentGender)) 
            { Console.WriteLine("Invalid gender. Please enter a valid gender:"); } 
            else { break; }
        }
        Console.WriteLine("Enter the average grade of the student:");
        double averageGrade;
        while (true)
        {
            averageGrade = Convert.ToDouble((Console.ReadLine()).Replace(".", ","));
            if (!(averageGrade >= 0.00 && averageGrade <= 5.00))
            { Console.WriteLine("Average grade must be between 0 and 5. Please enter a valid average grade:"); }
            else { break; }
        }
        Console.WriteLine("Enter the identification code of the student:");
        string identificationCode = Console.ReadLine();

        var newStudentt = new Student(firstName, lastName, course, studentId, Convert.ToString(studentGender), averageGrade, identificationCode);

        var combinedStudents = new Student[existingData.Students.Length + 1];
        existingData.Students.CopyTo(combinedStudents, 0);
        combinedStudents[existingData.Students.Length] = newStudentt;
        
        var combinedData = new StudentData
        {
            NumberOfStudents = combinedStudents.Length,
            Students = combinedStudents
        };

        await using (FileStream fs = new FileStream("Students.json", FileMode.Create))
        {
            await JsonSerializer.SerializeAsync(fs, combinedData, options);
            Console.WriteLine("New student has been added and data has been saved to file");
        }
    }

    static async Task DoTask()
    {
        bool someoneFound = false;
        foreach (var student in StudentArr._StudentsArr)
        {
            if (student.AverageGrade >= 4.5 && student.Course == 5 && student.GenderType == Student.Gender.Female)
            {
                someoneFound = true;
                Console.WriteLine(student.DisplayStudent(student));
            }
        }
        if (!someoneFound)
        {
            Console.WriteLine("No students found");
        }
    }
    
    static async Task SaveStudentsToFile()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true
        };

        var updatedData = new
        {
        NumberOfStudents = StudentArr._StudentsArr.Length,
        Students = StudentArr._StudentsArr
        };

        await using (FileStream fs = new FileStream("Students.json", FileMode.Create))
        {
            await JsonSerializer.SerializeAsync(fs, updatedData, options);
            Console.WriteLine("Updated data has been saved to file");
        }
    }
    
    static async Task DoSomethingWithEntities()
    {
        Random rnd = new Random();
        var randomStudent = StudentArr._StudentsArr[rnd.Next(0, StudentArr._StudentsArr.Length)];
        Storyteller story = new Storyteller(randomStudent.FirstName, rnd.Next(18, 25), "Fantasy");
        story.Introduce();
        story.TellStory();
        story.Cook();
        
        var randomStudent2 = StudentArr._StudentsArr[rnd.Next(0, StudentArr._StudentsArr.Length)];
        Dentist dentist = new Dentist(randomStudent2.FirstName, rnd.Next(18, 25), rnd.Next(1, 5));
        dentist.Introduce();
        dentist.PerformCheckup();
        dentist.Cook();
    }
}