namespace Auth;
public class Register{
private List<User> users = new List<User>();
//Sparar user i en lista, ska bytas ut till databasen

public User RegisterUser(string username, string password){
// metod för att skapa ny användare med det angivna username och password
if(string.IsNullOrEmpty(username)){
    throw new ArgumentException("Name cannot be null or empty");
//Exception om man inte har skrivt in något
} if(string.IsNullOrEmpty(password)){
    throw new ArgumentException("Password cannor be null or empty");
}//Exception om man inte har skrivt in något
User user = new User(username, password);
//Skapar en ny användarinsats med det angivna användarnamnet och lösenordet

users.Add(user);
// Lägger till den nya användarinsatsen till users listan
return user;
// returnerar den nya användarinsatsen
}

}

/*
public class Login{
//Ska generera en access token
}*/