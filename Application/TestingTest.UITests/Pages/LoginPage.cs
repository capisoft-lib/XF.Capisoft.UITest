using System;

// Aliases Func<AppQuery, AppQuery> with Query
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;
using StringQuery = System.Func<string, Xamarin.UITest.Queries.AppQuery>;

namespace TestingTest.UITests.Pages
{
    public class LoginPage : BasePage
    {
        readonly Query emailEntry;
        readonly Query usernameEntry;
        readonly Query passwordEntry;
        readonly Query loginButton;
        readonly Query signInButton;
        readonly Query lostPasswordButton;
        readonly StringQuery checkMarkForTask;
        readonly StringQuery taskListItem;

        public LoginPage()
        {
            emailEntry = x => x.TextField("EntryEmail");
            usernameEntry = x => x.TextField("EntryUsername");
            passwordEntry = x => x.TextField("EntryPassword");
            loginButton = x => x.Button("ButtonLogin");
            signInButton = x => x.Button("ButtonSignIn");
            lostPasswordButton = x => x.Button("ButtonLostPassword");

            if (OnAndroid)
            {
            }

            if (OniOS)
            {
            }
        }


        protected override PlatformQuery Trait => new PlatformQuery
        {
            Android = x => x.Marked("UITest App"),
            iOS = x => x.Marked("UITest App")
        };

        public LoginPage LoginWithCredentials(string username, string password)
        {
            EnterText(usernameEntry, username);
            EnterText(passwordEntry, password);
            app.Tap(loginButton);

            app.Tap("OK");

            return this;
        }

        public LoginPage SignIn(string email, string username, string password)
        {
            app.Tap(signInButton);
            app.WaitForElement(emailEntry);
            EnterText(emailEntry, email);
            EnterText(usernameEntry, username);
            EnterText(passwordEntry, password);
            app.Tap(loginButton);

            app.Tap("OK");

            return this;
        }

        public LoginPage LostPassword(string email, string username)
        {
            app.Tap(lostPasswordButton);
            app.WaitForElement(emailEntry);
            EnterText(emailEntry, email);
            EnterText(usernameEntry, username);
            app.Tap(loginButton);

            app.Tap("OK");

            return this;
        }
    }
}
