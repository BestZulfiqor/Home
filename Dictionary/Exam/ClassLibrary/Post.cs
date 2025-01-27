namespace ClassLibrary;

public class Post
{
    public string Title { get; set; }
    public Author Author { get; set; }
    public Car Car { get; set; }
    public string Description { get; set; }
    public int Likes { get; set; }
    public Post(string title, Author author, Car car, string description, int likes)
    {
        Title = title;
        Author = author;
        Car = car;
        Description = description;
        Likes = likes;
    }
}
