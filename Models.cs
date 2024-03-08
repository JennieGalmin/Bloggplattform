
using Microsoft.AspNetCore.Identity;

namespace Models;


public class User : IdentityUser{
    public new int Id {get; set;}
    public string Name {get; set;}
    public string Password {get; set;}

    public User(){}

    public User(int id, string name, string password){
        this.Id = id;
        this.Name = name;
        this.Password = password;
    }
}

public class Post
{
    public int Id {get; set;}
    public string Title {get; set;}
    public string Content {get; set;}
    public DateTime CreationDate {get; set; }
    public int UserId {get; set;}

    

    public Post(string title, string content, int userId){
        this.Title = title;
        this.Content = content;
        this.CreationDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        this.UserId = userId;
    }
}