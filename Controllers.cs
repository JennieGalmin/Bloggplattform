using Microsoft.AspNetCore.Mvc;
using Data;
using Models;

namespace Controllers;

//POST/user/register - Registrera användare. 
//POST/user/login - Logga in en användare och generera ett access Token.

[ApiController]
[Route("user")]

public class UserController : ControllerBase
{
    private readonly UserService userService;
    public UserController(UserService userService)
    {
        this.userService = userService;
    }
    [HttpPost("register")]
    public IActionResult Register([FromBody]User user){

        try{
            userService.RegisterUser(user.Name, user.Password);
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