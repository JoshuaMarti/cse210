public class WritingAssignment : Assignment {
    private string _title { get; set; }
    public WritingAssignment(string name, string topic, string title) : base(name, topic){
        _title = title;
    }
    public string GetWritingInformation(){
        string _name = sName();
        return $"{_title} by {_name}";
    }
}