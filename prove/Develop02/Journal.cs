using System.Diagnostics;
using System.IO;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
class Journal

{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry()
    {
        string userText;
        //Prompt user
        string prompt = PromptGenerator.GeneratePrompt();
        Console.WriteLine($"{prompt}");

        //Get input
        userText = Console.ReadLine();

        //Get date/time
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        //Save entry
        Entry userEntry = new Entry();
        userEntry._prompt = prompt;
        userEntry._entry = userText;
        userEntry._date = dateText;
        _entries.Add(userEntry);

        Console.WriteLine("...Entry recorded...");

        //_entries.Add(new Entry(userText, dateText, prompt));

    }
    public void DisplayJournal()
    {
        Console.WriteLine("...Displaying journal entries...");
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
        Console.WriteLine("...End of entries...");
    }

    public void LoadFromFile()
    {
        bool fileLoaded;
        string fileName;
        List<string> lines = new List<string>();
        do
        {
            Console.Write("Please enter your file name: ");
            fileName = Console.ReadLine();
            //Checks to see if file exists, wont continue until real file is presented.
            if (File.Exists(fileName))
            {
                //Because SaveToFile saves each entry as a set of 3 lines (prompt, date, entry)...
                //We must load files as a batch of 3 lines
                lines = System.IO.File.ReadAllLines(fileName).ToList();
                for (int i = 0; i < lines.Count; i = i + 3)
                {
                    Entry userEntry = new Entry();
                    userEntry._date = lines[i];
                    userEntry._prompt = lines[i + 1];
                    userEntry._entry = lines[i + 2];
                    _entries.Add(userEntry);
                }
                Console.WriteLine($"...The journal \"{fileName}\" has been loaded...");
                fileLoaded = true;
            }
            else
            {
                Console.WriteLine($"...The journal \"{fileName}\" does not exist...");
                fileLoaded = false;
            }
        } while (!fileLoaded);

    }
    public void SaveToFile()
    {
        string fileName;
        Console.Write("Please enter your file name: ");
        fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._prompt);
                outputFile.WriteLine(entry._entry);
            }
        }
        Console.WriteLine($"...The journal \"{fileName}\" has been saved...");
    }
}