class Entry()
{
    public string _entry;
    public string _mood;
    public string _date;
    public string _prompt;
    // public Entry(string entry, string date, string prompt)
    // {
    //     _entry = entry;
    //     _date = date;
    //     _prompt = prompt;
    // }

    public void DisplayEntry()
    {
        Console.WriteLine($"{_prompt} - {_date}");
        Console.WriteLine(_entry);
        Console.WriteLine($"Mood of the day: {_mood}");
    }
    

}