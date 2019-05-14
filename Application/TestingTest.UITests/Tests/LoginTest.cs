using System;
using NUnit.Framework;
using TestingTest.UITests.Pages;
using Xamarin.UITest;

namespace TestingTest.UITests.Tests
{
    public class LoginTest : BaseTestFixture
    {
        public LoginTest(Platform platform)
            : base(platform)
        {
        }

        [Test]
        public void _2_1_LoginSuccess()
        {
            base.LoginSuccess();
        }

        [Test]
        public void _2_2_LoginError()
        {
            base.Login("Other", "NoPassword");
        }

        [Test]
        public void _1_2_SignInError()
        {
            new LoginPage()
                .SignIn("Email", "Username", "ButNoPassword");
        }

        [Test]
        public void _1_1_SignInSuccess()
        {
            new LoginPage()
                .SignIn("Email", "Username", "Password");
        }

        [Test]
        public void _3_2_LostPasswordError()
        {
            new LoginPage()
                .LostPassword("InexistingEmail", "Username");
        }

        [Test]
        public void _3_1_LostPasswordSuccess()
        {
            new LoginPage()
                .LostPassword("Email", "Username");
        }

        //[Test]
        public void Repl()
        {
            app.Repl();
        }
    }
}