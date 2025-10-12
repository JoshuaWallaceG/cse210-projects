class Entry()
{
    public string _entry;
    public string _mood;
    public string _date;
    public string _prompt;

    public void DisplayEntry()
    {
        Console.WriteLine($"\"{_prompt}\" - {_date}");
        Console.WriteLine(_entry);
        Console.WriteLine($"Mood at entry: {_mood}");
    }

}