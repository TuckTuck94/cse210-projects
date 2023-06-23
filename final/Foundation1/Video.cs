public class Video
{
    public Video(string title, string author, int lengthInSeconds, List<Comment> comments)
    {
        Title = title;
        Author = author;
        LengthInSeconds = lengthInSeconds;
        Comments = comments;
    }

    public string Title { get; set; }
    
    public string Author { get; set; }
    
    public int LengthInSeconds { get; set; }
    
    public List<Comment> Comments { get; set; }

    public int GetAmountOfComments()
    {
        return Comments.Count;
    }
    
}