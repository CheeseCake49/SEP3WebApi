namespace Shared.Models;

public class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Name { get; set; }
    public string Role { get; set; }

    public User(string username, string password, string email, string name, string role)
    {
        Username = username;
        Password = password;
        Email = email;
        Name = name;
        Role = role;
    }
    
    public User()
    {
        
    }

}