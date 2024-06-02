using System.Globalization;

public class Video
{
    private string _title;
    private string _author;
    private int _length; //in seconds
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public int GetNumberOfComments()
    {
        int numberOfComments = _comments.Count;
        return numberOfComments;
    }
    public void GetVideoInfo()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Video Length: {_length} seconds");
        Console.WriteLine($"Number of comments: {GetNumberOfComments()}");
        foreach (Comment comment in _comments)
        {
            Console.Write("  ");
            Console.WriteLine(comment.GetComment());
        }
    }
}