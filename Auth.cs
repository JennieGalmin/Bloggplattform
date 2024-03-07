using Microsoft.EntityFrameworkCore;

namespace Auth;
public class Register
{

public User RegisterUser(string username, string password){
// metod för att skapa ny användare med det angivna username och password
if(string.IsNullOrEmpty(username)){
    throw new ArgumentException("Name cannot be null or empty");
//Exception om man inte har skrivt in något
} if(string.IsNullOrEmpty(password)){
    throw new ArgumentException("Password cannor be null or empty");
}//Exception om man inte har skrivt in något
User user = new User(username, password);
//Skapar en ny användarinsats med det angivna användarnamnet och lösenordet

return user;
// returnerar den nya användaren
}

}
//lägger till reister user (auth) in i databasen
public class AuthDbContext : DbContext
{
    public AuthDbContext(DbContextOptions<AuthDbContext> options ) : base(options)
    {}
    public DbSet<User> Users {get; set;}
}

/*
public class Login{
//Ska generera en access token
}*/