public class Assignment
{

    protected string _studentName = "";
    protected string _topic = "";
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }
    public string GetName()
    {
        return _studentName;
    }

    public string Gettopic()
    {
        return _topic;
    }
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }


}
