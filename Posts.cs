using System;
using Controllers;

namespace Posts;
public class Post
{
    public int Id {get; set;}
    public string Title {get; set;}
    public string Content {get; set;}
    public DateTime CreationDate {get; set; }
    public int UserId {get; set;}

    

    public Post(string title, string content, int userId){
        this.Title = title;
        this.Content = content;
        this.CreationDate = DateTime.SpecifyKind(DateTime.Now, DateTimeKind.Utc);
        this.UserId = userId;
    }
}




/*
public class GetAllPosts(){
    //hämta alla posts
}

public class GetPostById(){
    
}*/