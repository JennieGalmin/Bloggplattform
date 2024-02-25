//skapa postId som kopplas till userId när man ska skriva inlägg
public class Post
{
    public int Id {get; set;}
    public string Title {get; set;}
    public string Content {get; set;}
    public DateTime CreationDate {get; set; }
    public User Author {get; set; }

    public Post(string title, string content, DateTime creationDate){
        this.Title = title;
        this.Content = content;
        this.CreationDate = creationDate;
    }
}



public class GetAllPosts(){
    //hämta alla posts
}

public class GetPostById(){
    
}