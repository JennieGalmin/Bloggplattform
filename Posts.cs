//skapa postId som kopplas till userId när man ska skriva inlägg



using Microsoft.EntityFrameworkCore;

public class Post
{
    public int Id {get; set;}
    public string Title {get; set;}
    public string Content {get; set;}
    public DateTime CreationDate {get; set; }
    public User User {get; set; }

    

    public Post(string title, string content, User user){
        this.Title = title;
        this.Content = content;
        this.CreationDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        this.User = user;
    }
}

public class PostDbContext : DbContext
{
    public  DbSet<Post> posts {get; set;}

    public PostDbContext(DbContextOptions<PostDbContext> options) : base(options){}
}



public class GetAllPosts(){
    //hämta alla posts
}

public class GetPostById(){
    
}