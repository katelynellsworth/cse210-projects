class Word
{
    private string _word = "";

    public Word(string word)
    {
        _word = word;
    }
    public string HideWord()
    {    
        char[] wordAsChars = _word.ToCharArray();

        for (int i = 0; i < wordAsChars.Length; i++)
        {
            wordAsChars[i] = '_';
        }
        string combinedString = string.Join( "", wordAsChars);
        _word = combinedString;

        return _word;
    }
    public string GetWord()
    {
        return _word;
    }
    public override string ToString()
    {
        return _word;
    }
    
}
