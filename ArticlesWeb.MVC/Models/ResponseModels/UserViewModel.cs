using System;

namespace ArticlesWeb.MVC.Models.ResponseModels
{
    public class UserViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? BirthDate { get; set; }
        public string About { get; set; }
    }
}
