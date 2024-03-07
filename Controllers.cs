using Microsoft.AspNetCore.Mvc;
using Models;

namespace Controllers;

//POST/user/register - Registrera användare. 
//POST/user/login - Logga in en användare och generera ett access Token.
public class User{
    public string Name {get; set;}
    public string Password {get; set;}

    public User(string name, string password){
        this.Name = name;
        this.Password = password;
    }
}
[ApiController]
[Route("user")]

public class UserController : ControllerBase
{
    [HttpPost("register")]
    public User Register([FromBody]User user){
        return user;
    }

}
/*
    [HttpPost("login")]
    public string Login(){
    
        return "Login";
    }*/