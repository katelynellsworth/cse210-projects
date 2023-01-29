using System;
public class Entry 
{
    string _date = "";
    string _prompt = "";
    string _promptResponse = "";

    public Entry(string prompt, string response, string date)
    {
        _prompt = prompt;
        _promptResponse = response;
        _date = date;
    }

    public string get_prompt()
    {
        return _prompt;
    }
    public string get_promptResponse()
    {
        return _promptResponse;
    }
    public string get_date()
    {
        return _date;
    }
}