using System;
using System.IO;
using System.Security.Cryptography;
public class Journal
{
    public List<Entry>_entries = new();

    public void  AddEntry()
    {
       string prompt  = PromptGenerator.GetRandomPrompt();
       Console.WriteLine(prompt);
       Console.Write("Write the text of your entry as single string : > ");
       Console.ReadLine();
       string entryText = Console.ReadLine();

       Entry entry = new(prompt, entryText);

       _entries.Add(entry);
       
  

    }

    public void Display()
    {
        foreach(var entry in _entries)
        {
            entry.Display();
        }
    
    }
    public void SaveToFile(string  file)
    {
        using StreamWriter output = new(file);
        foreach (var entry in _entries)
        {
            output.WriteLine($"{entry._date}~{entry._promptText} ~{entry._entryText}");
        }
    }
    public void  LoadFromFile(string file)
    {
     string[] lines  = System.IO.File.ReadAllLines(file);

      foreach(string line in  lines )
      {
        string[] parts = line.Split("~");
          string promptText = parts[1];
          string entryTExt = parts[2];
          Entry entry = new(promptText,entryTExt)
          {
            _date = parts[0]
          };

          _entries.Add(entry);
      }

    }
}