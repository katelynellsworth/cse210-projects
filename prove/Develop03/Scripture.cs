class Scripture
{
    private string _scripture = "";
    private Reference _reference = new Reference("","","");
    private List<Word> _scriptureWords = new List<Word>();
    private List<int> _visableWordIndex = new List<int>();

    public Scripture(string book, string chapter, string verse, string scripture)
    {
        _reference = new Reference(book, chapter, verse);
        _scripture = scripture;
        _scriptureWords = ScriptureWords();
        _visableWordIndex = CreateVisableWordIndex();
    }
    public Scripture(string book, string chapter, string verse, string endVerse, string scripture)
    {
        _reference = new Reference(book, chapter, verse, endVerse);
        _scripture = scripture;
        _scriptureWords = ScriptureWords();
        _visableWordIndex = CreateVisableWordIndex();
    }
    private List<Word> ScriptureWords()
    {
        List<Word> _scriptureWords = new List<Word>();

        string[] words = _scripture.Split(' ');

        foreach (string word in words)
        {
            Word scriptureWord = new Word(word);
            _scriptureWords.Add(scriptureWord);
        }
        return _scriptureWords;
    }
    public string DisplayWholeScripture()
    {
        Console.Clear();

        string reference = _reference.FormatReference();
        string scripture = ConvertListToString();

        return $"{reference} {scripture}";
    }
    private string ConvertListToString()
    {
        string combinedString = string.Join( " ", _scriptureWords);
        return combinedString;
    }
    private List<int> CreateVisableWordIndex()
    {
        List<int> visableWordIndex = new List<int>();

        for (int i = 0; i < _scriptureWords.Count(); i++)
        {
            visableWordIndex.Add(i);
        }

        return visableWordIndex;
    }

    public List<Word> HideThreeRandomWords()
    {
        int hiddenCount = 0;

        while (hiddenCount < 3 && _visableWordIndex.Count() > 0)
        {
            Random random = new Random();
            int rnd = random.Next(0, _visableWordIndex.Count());
            
            int indexToHide = _visableWordIndex[rnd];
            _scriptureWords[indexToHide].HideWord();
            hiddenCount += 1;

            _visableWordIndex.RemoveAt(rnd);
        }
        
        return _scriptureWords;
    }
    public bool ScriptureHidden()
    {
        bool blank = true;

        if (_visableWordIndex.Count() > 0)
        {
            blank = false;
        }
        else if (_visableWordIndex.Count() == 0)
        {
            blank = true;
        }
        return blank;
    }
}





    // private string CapitilizeFirstWord()
    // {
    //     string[] words = _scripture.Split(' ');
    //     string firstWord = words[0];
    //     char[] firstWordAsChars = firstWord.ToCharArray();
    //     firstWordAsChars[0] = char.ToUpper(firstWord[0]);

    //     firstWord = firstWordAsChars.ToString();
    //     words[0] = firstWord;
    //     _scripture = words.ToString();

    //     return _scripture;
    // }