public class Video {
    private string _title;
    private string _author;
    private int _length;
    List<Comment> _comments = new List<Comment>();
    public int GetCommentCount() {return _comments.Count();}
    public void AddComment(string name, string text){
        Comment _comment = new Comment(name, text);
        _comments.Add(_comment);
    }
    public Video(string title, string author, int length){
        _title = title; _author = author; _length = length;
    }
    public void Display(){
        Console.WriteLine("\n\n" + _title + " by " + _author + ", " + _length +"\n" + GetCommentCount() + " Comments:");
        foreach (Comment comment in _comments){
            Console.WriteLine(comment.GetName() + ":\n" + comment.GetText() + "\n");
        }
    }
}