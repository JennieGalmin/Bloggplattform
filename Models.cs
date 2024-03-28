
using Microsoft.AspNetCore.Identity;

namespace Models;


public class User : IdentityUser<int>{
//Min User klass ärver från IdentityUser, där det redan finns email, användar id etc.
//int är invändar-idts typ.

    public User(){}
    //Var tvungen att lägga till en tom konstruktor eftersom programmet inte ville köra utan
    public User(string userName) : base(userName){}
    //En konstruktor som tar in username som parameter och lägger in en i User,
    // en overload tror jag.
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
//Vad en Post ska innehålla, jag har inte hunnit komma igång med det, dock borde jag ha börjat med det 
//inser jag i efterhand.