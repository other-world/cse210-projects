using System.Globalization;

public class Video
{
    private string _title;
    private string _author;
    private int _videoLength; //in seconds
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _videoLength = length;
    }
    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }
    public int NumOfComments()
    {
        int numberOfComments = _comments.Count;
        return numberOfComments;
    }
    public string GetVideoInfo()
    {
        return "GetVideoInfo-Return";
    }
}