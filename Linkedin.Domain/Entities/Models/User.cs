using Linkedin.Domain.Entities.BaseModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Linkedin.Domain.Entities.Models
{
    [Table("MyUser")]
    public class User : BaseModel
    {
        public string FirstName { get; set; }
        public string? LastName { get; set; }
        public string UserName { get; set; } = default!;
        // zadacha propertyni nomini o'zgartirish
        // zadacha
        // code first
        // database first
        // model first
        public string Password { get; set; }

        //[Display(Name = "MyPassword")]
        public string ConfirmPassword { get; set; }

        //[JsonPropertyName("MyEmail")]
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
    }
}
