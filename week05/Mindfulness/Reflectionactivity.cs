public class ReflectionActivity : Activity
{
    private static readonly List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need."
    };

    private static readonly List<string> _questions = new List<string>
    {
        "Why was this meaningful to you?",
        "How did you feel when it was complete?",
        "What could you learn from this experience?"
    };

    public ReflectionActivity() : base("Reflection Activity", "This activity helps you reflect on meaningful experiences.") { }

    public override void Run()
    {
        StartActivity();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        ShowSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            string question = _questions[rand.Next(_questions.Count)];
            Console.WriteLine(question);
            ShowSpinner(5);
        }

        EndActivity();
    }
}
