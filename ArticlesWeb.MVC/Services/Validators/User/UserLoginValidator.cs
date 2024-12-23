using ArticlesWeb.MVC.Models.RequestModels;
using FluentValidation;

namespace ArticlesWeb.MVC.Services.Validators.User
{
    public class UserLoginValidator : AbstractValidator<UserLoginModel>
    {
        public UserLoginValidator()
        {
            RuleFor(user => user.UsernameOrMail)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .WithMessage("Kullanıcı adı/email en az 3 karakter olmalıdır");

            RuleFor(user => user.Password)
                .NotEmpty()
                .NotNull()
                .Matches(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[*.!@$%^&(){}[]:;<>,.?/~_+-=|\]).{8,32}$");
        }
    }
}