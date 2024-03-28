using Data;
using Models;

namespace UserService
{
public class UserService{

private readonly RegisterUserDbContext userDbContext;
// En insatsvariabel av RegisterUser, den används för att spara data till databasen
public UserService(RegisterUserDbContext uDbContext){
userDbContext = uDbContext;
}
//Lägger till registeruserdbcontext till userservice så att jag kan lägga till 
//användare i servicen.
public User CreateUser(string name, string password){
//En metod för att skapa en användare med parametrar name och password som måste matcha.
if(string.IsNullOrEmpty(name)){
  throw new ArgumentException("Namnet måste vara ifyllt");
}
if(string.IsNullOrEmpty(password)){
  throw new ArgumentException("Lösenordet måste vara ifyllt");
}
//If sats om namn eller lösenord inte är ifyllt
//behöver inte vara med i contollern..


User user = new User();
//En ny insats av User för att representera en ny användare.
userDbContext.Add(user);
//Jag lägger till user till databasen
userDbContext.SaveChanges();
//Sparar ändringarna
return user;
//returnerar ny användare
}
}
}




     