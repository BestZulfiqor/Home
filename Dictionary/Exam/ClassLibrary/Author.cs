namespace ClassLibrary;

public class Author
{
    public string Name{get; set;}
    public int Age { get; set; }
    public string Email { get; set; }
    public bool Hascar { get; set; }
    public Author(string name, int age, string email, bool hascar)
    {
        this.Name = name;
        this.Age = age;
        this.Email = email;
        this.Hascar = hascar;
    }
}
