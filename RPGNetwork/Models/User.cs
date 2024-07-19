using System.ComponentModel.DataAnnotations;

namespace Project.Models;

public class User
{
    public Guid id { get; set; }
    public string name { get; set; }
    public string email { get; set; }

    public User() 
    {
        name = "Guest";
        email = "guest@rpgnetwork.com";
    }


}