using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linkedin.Domain.Entities.DTOs
{
    public class UserDTO
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; } = default!;
        public string Password { get; set; } = "sdfdsfas";
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
