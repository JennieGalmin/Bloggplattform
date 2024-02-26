using Microsoft.AspNetCore.Identity;


public class User : IdentityUser
{
    
    public User() : base(){}
    // en tom konstruktor eftersom det behövdes för att MapIdentityApi
    public List<Post> Posts {get; set;} = new List<Post>();
    // vill att posterna ska sparas till en viss användare, ska bytas ut till databas tror jag

    public User(string username, string password) : base()
    // User tar in två parametrar och anropas förälderklassen för User, vilket är IdentityUSer
    {
        UserName = username;
        PasswordHash = password;
    // Skriver in nya värden till parametrarna, så att namnen matchar.

    }
}
public class UserMessage
{


}

