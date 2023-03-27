class Video
{
    private string _title = "";
    private string _author = "";
    private int _lengthInSeconds = 0;
    private int _commentAmount = 0;
    private List<Comment> _comments = new List<Comment>();
    public Video(string title, string author, int lengthInSeconds, List<Comment> comments)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = comments;
        _commentAmount = CountComments();
    }
    public string GetTitle()
    {
        return _title;
    }
    public void SetTitle(string title)
    {
        _title = title;
    }
    public string GetAuthor()
    {
        return _author;
    }
    public void SetAuthor(string author)
    {
        _author = author;
    }
    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }
    public void SetLengthInSeconds(int seconds)
    {
        _lengthInSeconds = seconds;
    }
    public List<Comment> GetComments()
    {
        return _comments;
    }
    public void SetComment()
    {
        Console.WriteLine("Write code of this.");
    }
    private int CountComments()
    {
        var count = 0;
        foreach(var comment in _comments)
        {
            count++;
        }
        return count;
    }
    public void DisplayVideo()
    {
        string videoString = $"{_title} by {_author} Duration: {_lengthInSeconds} seconds Comments: {_commentAmount}";
        Console.WriteLine(videoString);

        foreach(var comment in _comments)
        {
            comment.DisplayComment();
        }
        Console.WriteLine("");
    }



}