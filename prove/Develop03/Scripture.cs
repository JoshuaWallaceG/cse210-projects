using System.Security.Cryptography.X509Certificates;

public class Scripture
{
    private string _scriptureText; 
    private List<Word> _wordList = new List<Word>();
    private Reference _reference;

    public Scripture(string scripture, Reference reference)
    {
        //Upon initializing the Scripture variable, it splits the string into a list of words
        _scriptureText = scripture;
        _reference = reference;
        string[] tempWordArray = _scriptureText.Split(' ');
        foreach (string w in tempWordArray)
        {
            _wordList.Add(new Word(w, false));
        }
    }
    
    public static Random random = new Random();
    public void blankPercent(int percent)
    {
        //Because users can choose the blank percentage to be a low amount like 1%, I have a loop that makes sure that at least 1 word is blanked each round
        bool blankedAtLeastOne = false;
        do
        {
            for (int i = 0; i < _wordList.Count; i++)
            {
                if (random.Next(0, 100) < percent && !_wordList[i].getHidden())
                {
                    _wordList[i].hideWord();
                    blankedAtLeastOne = true;
                }
            }
        } while (!blankedAtLeastOne);
    }

    public void printVerse()
    {
        foreach (Word w in _wordList)
        {
            Console.Write($"{w.getWord()} ");
        }
        Console.WriteLine();
    }

    public void printReference()
    {
        Console.WriteLine(_reference.getReference());
    }

    //Simply goes through and checks if all the words are blanked. If it finds a single word that is not blanked, it returns early with false
    public bool checkIfFullyBlanked()
    {
        for (int i = 0; i < _wordList.Count; i++)
        {
            if (!_wordList[i].getHidden())
            {
                return false;
            }
        }
        return true;
    }
}