using System.ComponentModel.DataAnnotations;

namespace ArticlesWeb.MVC.Models.RequestModels
{
    public class UserLoginModel
    {
        public string UsernameOrMail { get; set; }
        public string Password { get; set; }
    }
}
