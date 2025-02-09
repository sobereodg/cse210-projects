public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity helps you relax by guiding your breathing.") { }

    public override void Run()
    {
        StartActivity();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("Breathe in...");
            ShowCountdown(3);
            Console.WriteLine("Breathe out...");
            ShowCountdown(3);
        }

        EndActivity();
    }

    private void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}
