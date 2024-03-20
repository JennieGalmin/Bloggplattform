using Data;
using Models;

namespace UserService
{
public class UserService{

private readonly RegisterUserDbContext userDbContext;
public UserService(RegisterUserDbContext uDbContext){
userDbContext = uDbContext;
}
public User CreateUser(string name, string password){

if(string.IsNullOrEmpty(name)){
  throw new ArgumentException("Namnet måste vara ifyllt");
}
if(string.IsNullOrEmpty(password)){
  throw new ArgumentException("Lösenordet måste vara ifyllt");
}

User user = new User();

userDbContext.Add(user);
userDbContext.SaveChanges();
return user;

}
}
}




     