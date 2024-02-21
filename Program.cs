
using Microsoft.AspNetCore.Mvc;


namespace Bloggplattform;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers();
        builder.Services.AddScoped<Register>();

        var app = builder.Build();

        app.MapControllers();

        app.UseHttpsRedirection();

        app.Run();
    }
}

/*Endpointsen/Controllers:
POST/api/auth/register - Registrera användare. 
POST/api/auth/login - Logga in en användare och generera ett access Token.
GET/api/posts - Hämtar alla blogginlägg.
GET/api/posts/{postsId} - Hämtar ett specifikt blogginlägg.
POST/api/posts/{postsId}/comments - Kan kommentera på ett specifikt blogginlägg.
POST/api/message/user/{userId} - Kan skicka meddelanden till en annan användare.
DELETE/api/comments/{commentsId} - Tar bort en kommentar.*/

[ApiController]
[Route("api/auth")]
public class AuthControllers : ControllerBase
{
    [HttpPost("register")]
    public string Register(){
        return "Register";
    }
    [HttpPost("login")]
    public string Login(){
        return "Login";
    }
}
[Route("api/posts")]
public class PostsControllers : ControllerBase
{

}