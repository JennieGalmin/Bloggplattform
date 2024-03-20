using Microsoft.AspNetCore.Mvc;

using UserService;
using Models;


namespace Controllers;

//POST/user/register - Registrera användare. 
//POST/user/login - Logga in en användare och generera ett access Token.

[ApiController]
[Route("user")]

public class UserController : ControllerBase
{
    private readonly UserService.UserService userService;
    public UserController(UserService.UserService userService)
    {
        this.userService = userService;
    }
    [HttpPost("register")]
    public IActionResult CreateUser([FromBody]User user){

        try{
            if(string.IsNullOrEmpty(user.UserName)){
                return BadRequest("Du måste skriva in användarnamn");
            }
            if(string.IsNullOrEmpty(user.PasswordHash)){
                return BadRequest("Du måste skriva in löserord");
            }
            userService.CreateUser(user.UserName, user.PasswordHash);
            return Ok("Användare registrerad");
        } catch (Exception){
           return NotFound();
        }
        
       
    }

}
/*
    [HttpPost("login")]
    public string Login(){
    
        return "Login";
    }*/