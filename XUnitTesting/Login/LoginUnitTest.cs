using System;
using System.Threading.Tasks;
using TestingTest.Services;
using TestingTest.ViewModels;
using Xunit;

namespace XUnitTesting.Login
{
    public class LoginUnitTest
    {
        protected ILoginService loginService { get; set; }
        protected LoginViewModel loginViewModel { get; set; }

        public LoginUnitTest()
        {
            loginService = new MockLoginService();
            loginViewModel = new LoginViewModel(loginService);
        }

        [Fact]
        public async Task LoginSuccessTest()
        {
            loginViewModel.Username = "USERNAME";
            loginViewModel.Password = "USERNAME";
            bool hasLogin = await loginViewModel.Login();
            Assert.True(hasLogin);
        }

        [Fact]
        public async Task LoginErrorTest()
        {
            loginViewModel.Username = "USERNAME";
            loginViewModel.Password = "PASSWORD";
            bool hasLogin = await loginViewModel.Login();
            Assert.False(hasLogin);
        }

        [Fact]
        public async Task SigninSuccessTest()
        {
            loginViewModel.Username = "USERNAME";
            loginViewModel.Password = "USERNAME";
            loginViewModel.Email = "USERNAME";
            bool hasSignin = await loginViewModel.Signin();
            Assert.True(hasSignin);
        }

        [Fact]
        public async Task SigninErrorTest()
        {
            loginViewModel.Username = "USERNAME";
            loginViewModel.Password = "PASSWORD";
            loginViewModel.Email = "EMAIL";
            bool hasSignin = await loginViewModel.Signin();
            Assert.False(hasSignin);
        }

        [Fact]
        public async Task LostPasswordSuccessTest()
        {
            loginViewModel.Username = "USERNAME";
            loginViewModel.Email = "USERNAME";
            bool hasProcessed = await loginViewModel.LostPassword();
            Assert.True(hasProcessed);
        }

        [Fact]
        public async Task LostPasswordErrorTest()
        {
            loginViewModel.Username = "USERNAME";
            loginViewModel.Email = "EMAIL";
            bool hasProcessed = await loginViewModel.LostPassword();
            Assert.False(hasProcessed);
        }
    }
}