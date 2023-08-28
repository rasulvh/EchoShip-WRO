using Microsoft.AspNetCore.Identity;

namespace EchoShip.Models
{
    public class AppUser : IdentityUser
    {
        public string Fullname { get; set; }
    }
}
