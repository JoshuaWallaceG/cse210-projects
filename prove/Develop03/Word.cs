public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word, bool hidden)
    {
        _word = word;
        _hidden = hidden;
    }

    public bool getHidden()
    {
        return _hidden;
    }

    public void hideWord()
    {
        _hidden = true;
    }

    public string getWord()
    {
        if (_hidden)
        {
            string hiddenWord = "";
            for (int i = 0; i < _word.Length; i++)
            {
                hiddenWord += "_";
            }
            return hiddenWord;
        }
        else
        {
            return _word;
        }
    }
}