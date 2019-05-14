using System;
using System.Collections.Generic;
using TestingTest.Services;
using TestingTest.ViewModels;
using Xamarin.Forms;

namespace TestingTest.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel ViewModel { get; set; }

        public LoginPage()
        {
            this.ViewModel = new LoginViewModel(new LoginService());
            this.BindingContext = this.ViewModel;
            InitializeComponent();
        }

        public LoginPage(ILoginService service)
        {
            this.ViewModel = new LoginViewModel(service);
            this.BindingContext = this.ViewModel;
            InitializeComponent();
        }

        async void Handle_Clicked_Login(object sender, System.EventArgs e)
        {
            if (!this.ViewModel.EmailVisible)
            {
                if (await this.ViewModel.Login())
                {
                    await DisplayAlert("Login", "Success", "OK");
                }
                else
                {
                    await DisplayAlert("Login", "Error", "OK");
                }
                this.ViewModel.EmailVisible = false;
                this.ViewModel.PasswordVisible = true;
            }
            else if (!this.ViewModel.PasswordVisible)
            {
                if (await this.ViewModel.LostPassword())
                {
                    await DisplayAlert("Lost Password", "Success", "OK");
                }
                else
                {
                    await DisplayAlert("Lost Password", "Error", "OK");
                }
                this.ViewModel.EmailVisible = false;
                this.ViewModel.PasswordVisible = true;
            }
            else
            {
                if (await this.ViewModel.Signin())
                {
                    await DisplayAlert("Sign In", "Success", "OK");
                }
                else
                {
                    await DisplayAlert("Sign In", "Error", "OK");
                }
                this.ViewModel.EmailVisible = false;
                this.ViewModel.PasswordVisible = true;
            }
        }

        void Handle_Clicked_NoAccount(object sender, System.EventArgs e)
        {
            if (!this.ViewModel.EmailVisible)
            {
                this.ViewModel.EmailVisible = true;
            }
            else
            {
                this.ViewModel.EmailVisible = false;
            }
            this.ViewModel.PasswordVisible = true;
        }

        void Handle_Clicked_LostPassword(object sender, System.EventArgs e)
        {
            this.ViewModel.EmailVisible = true;
            this.ViewModel.PasswordVisible = false;
        }
    }
}
