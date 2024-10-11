namespace Lab3;
public class Storyteller : Person, ICook
{
    public string StoryGenre { get; set; }

    public Storyteller(string name, int age, string storyGenre) : base(name, age)
    {
        StoryGenre = storyGenre;
    }

    public void TellStory()
    {
        Console.WriteLine($"{Name} is telling a {StoryGenre} story.");
    }

    public void Cook()
    {
        Console.WriteLine($"{Name} is cooking a delicious meal.");
    }

    public override void Introduce()
    {
        Console.WriteLine($"Hi, I am {Name}, a {Age}-year-old storyteller.");
    }
}