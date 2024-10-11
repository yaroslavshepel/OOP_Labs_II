namespace Lab3;
public class Dentist : Person, ICook
{
    public int ExperienceYears { get; set; }

    public Dentist(string name, int age, int experienceYears) : base(name, age)
    {
        ExperienceYears = experienceYears;
    }

    public void PerformCheckup()
    {
        Console.WriteLine($"{Name} is performing a dental checkup.");
    }

    public void Cook()
    {
        Console.WriteLine($"{Name} is cooking a delicious meal.");
    }

    public override void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name}, a {Age}-year-old dentist with {ExperienceYears} years of experience.");
    }
}