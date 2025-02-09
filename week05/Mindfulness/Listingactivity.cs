public class ListingActivity : Activity
{
    private static readonly List<string> _prompts = new List<string>
    {
        "List people you appreciate.",
        "List personal strengths you have.",
        "List times you helped someone."
    };

    public ListingActivity() : base("Listing Activity", "This activity helps you list things you appreciate.") { }

    public override void Run()
    {
        StartActivity();
        Random rand = new Random();
        string prompt = _prompts[rand.Next(_prompts.Count)];

        Console.WriteLine(prompt);
        ShowSpinner(3);

        List<string> responses = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            responses.Add(Console.ReadLine());
        }

        Console.WriteLine($"You listed {responses.Count} items.");
        EndActivity();
    }
}
