class Entry
{
    public string _date;
    public string _question;
    public string _response;

    public Entry(string question, string response)
    {
        _date = DateTime.Now.ToShortDateString();
        _question = question;
        _response = response;
    }


    public string Display()
    {
        return $"{_date} - {_question}\n{_response}\n";
    }

    public string ToFileString()
    {
        return $"{_date}|{_question}|{_response}";
    }

    public static Entry FromFileString(string line)
    {
        string[] parts = line.Split('|');
        return new Entry(parts[1], parts[2]) { _date = parts[0] };
    }
}