public class MathAssignment : Assignment {
    private string _textbookSection { get; set; }
    private string _problems { get; set; }
    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name, topic){
        _textbookSection = textbookSection;
        _problems = problems;
    }
    public string GetHomeworkList(){
        return $"Section {_textbookSection}, Problem[s]{_problems}";
    }
}