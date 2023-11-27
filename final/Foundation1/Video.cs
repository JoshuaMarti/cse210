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
}