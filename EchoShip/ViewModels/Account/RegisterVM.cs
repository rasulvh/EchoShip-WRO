using System.ComponentModel.DataAnnotations;

namespace EchoShip.ViewModels.Account
{
    public class RegisterVM
    {
        public string Fullname { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string Username { get; set; }
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}
