using System;
using NUnit.Framework;
using TestingTest.UITests.Pages;
using Xamarin.UITest;

namespace TestingTest.UITests
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class BaseTestFixture
    {
        protected IApp app => AppInitializer.App;
        protected bool OnAndroid => AppInitializer.Platform == Platform.Android;
        protected bool OniOS => AppInitializer.Platform == Platform.iOS;

        protected BaseTestFixture(Platform platform)
        {
            AppInitializer.Platform = platform;
        }

        [SetUp]
        public virtual void BeforeEachTest()
        {
            AppInitializer.StartApp();
        }

        protected void LoginSuccess()
        {
            Login("Username", "Password");
        }

        protected void Login(string username, string password = null)
        {
            new LoginPage().LoginWithCredentials(username, password);
        }
        // You can edit this file to define functionality that is common across many or all tests.
        // For example, you could add a method here to log in or dismiss a welcome dialogue.
    }
}
