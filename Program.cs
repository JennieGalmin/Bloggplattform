
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

using Controllers;
using Models;
using Data;


namespace Bloggplattform;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddAuthentication().AddBearerToken(IdentityConstants.BearerScheme);
        //För att man ska kunna få ett token när man loggar in
        builder.Services.AddIdentityCore<User>()
        //för att använda identity tjänsterna för autnentisering och auktorisering. 
            .AddEntityFrameworkStores<RegisterUserDbContext>()
            //denna metod säger att jag vill använda entityframework för att lagra informationen av användaren.
            //RegisteruserDbContext är ansvarig för att lagra användarinformationen.
            .AddApiEndpoints();
        builder.Services.AddControllers();
        //Kan hantera HTTP-åtgärder och skicka svar till klient.
        

        builder.Services.AddScoped<UserService.UserService, UserService.UserService>();
        builder.Services.AddScoped<UserController>();
        //AddScoped för att lägga till en instans av servicen, klassen. 

        builder.Services.AddDbContext<RegisterUserDbContext>(options => 
        options.UseNpgsql("Host=localhost;Database=bloggplattform;Username=postgres;Password=password"));

        builder.Services.AddDbContext<PostDbContext>(
            options => options.UseNpgsql("Host=localhost;Database=bloggplattform;Username=postgres;Password=password"));
     
        //Här uppdateras datan genom databasen och sparas. 
        //Jag förstår nu att jag hade kunnat göra en DbContext till post och lagt in user i den.

        

        var app = builder.Build();
        //Bygger den uppdaterade variationen av applikationen med hjälp av builder.

        app.MapIdentityApi<User>();
        //Detta gör så att alla API-rutter kommer att hanteras av ASP.Net core piplines.
        app.MapControllers();
        //Samma med denna rad som ovan.
        app.UseAuthentication();
        //Aktiverar autentisering.
        app.UseAuthorization();
        //Aktiverar auktorisering.
        app.UseHttpsRedirection();
        //Gör så att HTTP-förfrågningar görs om till HTTPS. Detta blir mer säkert.  
        app.Run();
        //Startar applikationen och den börjar lyssna efter HTTP förfrågningar. 
    }

}




/*//POST/api/auth/register - Registrera användare. 
//POST/api/auth/login - Logga in en användare och generera ett access Token.
[ApiController]
[Route("api/auth")]
public class AuthControllers : ControllerBase
{
    private readonly Register _register;
    public AuthControllers(Register register){
        _register = register;
    }
    [HttpPost("register")]
    public IActionResult RegisterUser(string username, string password){
        User registerdUser = _register.RegisterUser(username, password);
        return Ok(registerdUser);
    }

    [HttpPost("login")]
    public string Login(){
        return "Login";
    }
}

//GET/api/posts - Hämtar alla blogginlägg.
//GET/api/posts/{postsId} - Hämtar ett specifikt blogginlägg.
//POST/api/posts/{postsId}/comments - Kan kommentera på ett specifikt blogginlägg.

[ApiController]
[Route("api/posts")]
public class PostsControllers : ControllerBase
{
[HttpGet("")]
public string GetAllPosts(){
 return "getallposts";
}
[HttpGet("/*postsId")]
public string GetPostById(){
    return "getpostsbyId";
}

}
//POST/api/message/user/{userId} - Kan skicka meddelanden till en annan användare.
[ApiController]
[Route("api/message")]

public class MessageController : ControllerBase{
[HttpPost("user/{userId}")]
public new void User([FromBody] User user)
{
 
}
}
//DELETE/api/comments/{commentsId} - Tar bort en kommentar.
[ApiController]
[Route("api/comments")]
public class CommentController : ControllerBase
{
    [HttpDelete("")]//commentsId
    public string Comments(){
        return "comments";
    }
}*/
