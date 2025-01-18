public class Entry
{
    public string Prompt { get; }
    public string Response { get; }
    public string Date { get; } // 

    public Entry(string prompt, string response, string date)
    {
        Prompt = prompt;
        Response = response;
        Date = date;
    }

    public void Display()
    {
        Console.WriteLine($"\nDate: {Date}");
        Console.WriteLine($"Prompt: {Prompt}");
        Console.WriteLine($"Response: {Response}");
    }

    public override string ToString()
    {
        return $"{Prompt}|{Response}|{Date}";
    }
}
