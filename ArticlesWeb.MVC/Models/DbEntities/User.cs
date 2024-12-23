using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace ArticlesWeb.MVC.Models.DbEntities
{
    public class User : IdentityUser<Guid>
    {
        public string FullName => $"{FirstName} {LastName}";
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string About { get; set; }
        public bool IsAdmin { get; set; }

        public User()
        {
            RegistrationDate = DateTime.UtcNow;
            EmailConfirmed = false;
            IsAdmin = false;
        }
    }
}
