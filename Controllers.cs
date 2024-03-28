using Microsoft.AspNetCore.Mvc;

using UserService;
using Models;


namespace Controllers;

//POST/user/register - Registrera användare. 
//POST/user/login - Logga in en användare och generera ett access Token.

[ApiController]
//Ett attribut till klassen för att indikera att det är ett webb API  
[Route("user")]
//Route för att komma åt rutten i urlen

public class UserController : ControllerBase
//Controller klassen ärver från ControllerBase
//ContollerBase har funktionalitet för att hantera HTTP förfrågningar och generara svar. 
{
    private readonly UserService.UserService userService;
    //En instansvariabel för att kunna använda innehållet i Servicen.
    public UserController(UserService.UserService userService)
    {
        this.userService = userService;
    }
    //Konstruktorn som tar emot en insats av userservice klassen
    //Ett dependency injection

    [HttpPost("register")]
    //Ett attribut till CreateUser metoden för att svara på HTTP förfrågningar
    //till route user/register
    public IActionResult CreateUser([FromBody]User user){
        //Åtgärden för att skapa en ny användare. Den tar emot en förfrågan och 
        // returnerar ett anävndarobjekt.
        try{
            if(string.IsNullOrEmpty(user.UserName)){
                return BadRequest("Du måste skriva in användarnamn");
            }
            if(string.IsNullOrEmpty(user.PasswordHash)){
                return BadRequest("Du måste skriva in löserord");
            }
            //If sats om användaren inte skulle skriva in namn eller lösenord korrekt.
            userService.CreateUser(user.UserName, user.PasswordHash);
            return Ok("Användare registrerad");
            //Här skapas en ny användare om namn och lösenord har skrivits in korrekt.
        } catch (Exception){
           return NotFound();
        } // Om det blir något exceptionfel så hanteras det.
        
       
    }

}
//login ska finnas med automantiskt i IdentityCore, DbContext.