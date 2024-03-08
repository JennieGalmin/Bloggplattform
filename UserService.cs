using Data;
using Models;


public class UserService{
  private RegisterUserDbContext context;

  public UserService(RegisterUserDbContext context){
    this.context = context;
  }  
public User RegisterUser(string name, string password){
     
var newUser = new User{
    Name = name,
    Password = password
};
     context.Users.Add(newUser);
     context.SaveChanges();
    return newUser;
}



}


     