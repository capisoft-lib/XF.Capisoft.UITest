using System;
using System.Threading.Tasks;

namespace TestingTest.Services
{
    public class LoginService : ILoginService
    {
        private const string SUCCESS_EMAIL = "Email";
        private const string SUCCESS_USERNAME = "Username";
        private const string SUCCESS_PASSWORD = "Password";

        public LoginService()
        {
        }


        public async Task<bool> Login(string username, string password)
        {
            return await Task.Factory.StartNew<bool>(() =>
            {
                return SUCCESS_USERNAME.Equals(username) && SUCCESS_PASSWORD.Equals(password);
            });
        }

        public async Task<bool> LostPassword(string email, string username)
        {
            return await Task.Factory.StartNew<bool>(() =>
            {
                return SUCCESS_EMAIL.Equals(email) && SUCCESS_USERNAME.Equals(username);
            });
        }

        public async Task<bool> Signin(string email, string username, string password)
        {
            return await Task.Factory.StartNew<bool>(() =>
            {
                return SUCCESS_EMAIL.Equals(email) && SUCCESS_USERNAME.Equals(username) && SUCCESS_PASSWORD.Equals(password);
            });
        }
    }
}
