using System;
using System.IO;
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator _promptGenerator = new PromptGenerator();

    public void AddEntry()
    {
        string prompt = _promptGenerator.GetRandomPrompt();

        Console.WriteLine(prompt);
        Console.Write("> ");
        string response = Console.ReadLine();

        string currentDate = DateTime.Now.ToShortDateString();

        Entry newEntry = new Entry(prompt, response, currentDate);
        _entries.Add(newEntry);

        Console.WriteLine("Entry added successfully.");
    }

    public void DisplayJournal()
    {
        if (_entries.Count == 0)
        {
            
        }
        else
        {
            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
    }

    public void SaveToFile()
    {
        Console.Write("Enter the filename to save to: ");
        string filename = Console.ReadLine();

        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }

        Console.WriteLine($"Journal saved successfully to {filename}.");
    }

     public void LoadFromFile()
    {
        Console.Write("Enter the filename to load from: ");
        string filename = Console.ReadLine();

        if (File.Exists(filename))
        {
            _entries.Clear();

            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 3)
                {
                    string prompt = parts[0];
                    string response = parts[1];
                    string date = parts[2];

                    Entry entry = new Entry(prompt, response, date);
                    _entries.Add(entry);
                }
            }

            Console.WriteLine($"Journal loaded successfully from {filename}");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
