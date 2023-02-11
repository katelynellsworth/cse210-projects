class Reference
{
    private string _book = "";
    private string _chapter = "";
    private string _verse = "";
    private string _endVerse = "";

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }
    public string FormatReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
        public string formatReferenceWithEndVerse()
    {
        return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}




    // private string CaptilizeBook()
    // {
    //     char[] bookAsChar = _book.ToCharArray();
    //     bookAsChar[0] = char.ToUpper(_book[0]);
    //     _book = bookAsChar.ToString();

    //     return _book;
    // }