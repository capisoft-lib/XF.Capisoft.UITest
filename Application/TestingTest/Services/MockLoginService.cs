using System;
using System.Threading.Tasks;

namespace TestingTest.Services
{
    public class MockLoginService : ILoginService
    {


        public MockLoginService()
        {
        }

        public async Task<bool> Login(string username, string password)
        {
            return await Task.Factory.StartNew<bool>(() =>
            {
                return username.Equals(password);
            });
        }

        public async Task<bool> Signin(string email, string username, string password)
        {
            return await Task.Factory.StartNew<bool>(() =>
            {
                return email.Equals(username) && email.Equals(password);
            });
        }

        public async Task<bool> LostPassword(string email, string username)
        {
            return await Task.Factory.StartNew<bool>(() =>
            {
                return email.Equals(username);
            });
        }
    }
}
