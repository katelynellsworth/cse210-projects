class Comment
{
    private string _name = "";
    private string _comment = "";
    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }
    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name;
    }
    public string GetCommment()
    {
        return _comment;
    }
    public void SetComment(string comment)
    {
        _comment = comment;
    }
    public void DisplayComment()
    {
        Console.WriteLine($"> {_name} - {_comment}");
    }

}