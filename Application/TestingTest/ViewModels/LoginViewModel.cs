using System;
using System.Threading.Tasks;
using TestingTest.Services;

namespace TestingTest.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        protected ILoginService loginService { get; set; }

        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        private bool emailVisible = false;
        public bool EmailVisible { get => emailVisible; set { emailVisible = value; NotifyPropertyChanged(); } }

        private bool passwordVisible = true;
        public bool PasswordVisible { get => passwordVisible; set { passwordVisible = value; NotifyPropertyChanged(); } }

        public LoginViewModel(ILoginService service) : base()
        {
            loginService = service;
        }

        public async Task<bool> Login()
        {
            return await loginService.Login(Username, Password);
        }

        public async Task<bool> Signin()
        {
            return await loginService.Signin(Email, Username, Password);
        }

        public async Task<bool> LostPassword()
        {
            return await loginService.LostPassword(Email, Username);
        }
    }
}
