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
        string prompt = "What was the best part of today?";
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

        //_entries.Add(new Entry(userText, dateText, prompt));

    }
    public void DisplayJournal()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }


    public void LoadFromFile()
    {
        bool fileLoaded;
        string fileName;
        int lineAmount = 0;
        List<string> lines = new List<string>();
        do
        {
            Console.Write("Please enter your file name: ");
            fileName = Console.ReadLine();
            //List of if statements to filter out bad file entries (empty or non extistant)
            if (File.Exists(fileName))
            {
                lines = System.IO.File.ReadAllLines(fileName).ToList();
                lineAmount = lines.Count;
                if (lineAmount == 0)
                {
                    Console.WriteLine($"The journal \"{fileName}\" is empty.");
                    fileLoaded = false;
                }
                else
                {
                    Console.WriteLine($"The journal \"{fileName}\" has been loaded.");
                    fileLoaded = true;
                }
            }
            else
            {
                Console.WriteLine($"The journal \"{fileName}\" does not exist.");
                fileLoaded = false;
            }
        } while (!fileLoaded);
        
        Console.WriteLine($"DEBUG: LINE COUNT IS {lineAmount}, ENTRY COUNT IS {lineAmount / 3}");
        for (int i = 0; i < lineAmount; i = i + 3)
        {
            Entry userEntry = new Entry();
            userEntry._date = lines[i];
            userEntry._prompt = lines[i + 1];
            userEntry._entry = lines[i + 2];
            _entries.Add(userEntry);
        }

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
    }
}