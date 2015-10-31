namespace _01_School_task
{
    public interface ICommentable
    {
        // I've decided to use the interface for adding properties to my other classes. I'll use additional constructor if there is a need to add a comment.
        string Comment { get; }
    }
}
