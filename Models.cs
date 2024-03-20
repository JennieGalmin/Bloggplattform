
using Microsoft.AspNetCore.Identity;

namespace Models;


public class User : IdentityUser<int>{
   

    public User(){}

    public User(string userName) : base(userName){}
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