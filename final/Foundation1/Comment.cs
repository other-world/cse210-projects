public class Comment
{
    private string _commenterName;
    private string _commentText;

    public Comment(string name, string comment)
    {
        _commenterName = name;
        _commentText = comment;
    }

    public string GetComment()
    {
        return "GetComment-Return";
    }

}