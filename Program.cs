
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
        builder.Services.AddIdentityCore<User>()
            .AddEntityFrameworkStores<PostDbContext>()
            .AddApiEndpoints();
        builder.Services.AddControllers();


        builder.Services.AddDbContext<RegisterUserDbContext>(options => 
        options.UseNpgsql("Host=localhost;Database=bloggplattform;Username=postgres;Password=password"));

        builder.Services.AddDbContext<PostDbContext>(
            options => options.UseNpgsql("Host=localhost;Database=bloggplattform;Username=postgres;Password=password"));
     
        builder.Services.AddScoped<UserController>();

        var app = builder.Build();

        app.MapIdentityApi<User>();
        app.MapControllers();
        app.UseAuthentication();
        app.UseAuthorization();

        app.UseHttpsRedirection();

        app.Run();
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
