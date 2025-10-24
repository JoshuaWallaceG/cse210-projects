public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word, bool hidden)
    {
        _word = word;
        _hidden = hidden;
    }

    public bool GetHidden()
    {
        return _hidden;
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            //Creates a temporary string and adds the correct amount if "_" to it, then returns said string
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