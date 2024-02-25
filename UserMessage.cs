using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public List<Post> Posts {get; set;} = new List<Post>();// vill att posterna ska sparas i en viss användare

    public User(){}
}
public class UserMessage
{


}

