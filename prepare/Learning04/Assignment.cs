public class Assignment {
    private string _studentName { get; set; }
    private string _topic { get; set; }
    public string GetSummary(){
        return $"{_studentName} - {_topic}";
    }
    public string sName(){return _studentName;}
    public Assignment(string name, string topic){
        _studentName = name;
        _topic = topic;
    }
}