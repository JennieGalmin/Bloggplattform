using Microsoft.EntityFrameworkCore;
using Models;


namespace Data

{
    public class RegisterUserDbContext : DbContext
    {
        public DbSet<User> Users {get; set;}

        public RegisterUserDbContext(DbContextOptions<RegisterUserDbContext> options) : base(options){}
    }
}
//


public class PostDbContext : DbContext
{
    public  DbSet<Post> posts {get; set;}

    public PostDbContext(DbContextOptions<PostDbContext> options) : base(options){}
}


