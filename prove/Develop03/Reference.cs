public class Reference
{
    private string _book;
    private string _chapter;
    private string _verses;

    //Two different constructors depending if the user has a single verse, or multi-verse reference

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = verse;
    }

    public Reference(string book, string chapter, string startingVerse, string endingVerse)
    {
        _book = book;
        _chapter = chapter;
        _verses = $"{startingVerse}-{endingVerse}";
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verses}";
    }

}