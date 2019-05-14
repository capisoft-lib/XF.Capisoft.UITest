using System;
using System.Threading.Tasks;

namespace TestingTest.Services
{
    public interface ILoginService
    {
        Task<bool> Login(string username, string password);
        Task<bool> Signin(string email, string username, string password);
        Task<bool> LostPassword(string email, string username);
    }
}
