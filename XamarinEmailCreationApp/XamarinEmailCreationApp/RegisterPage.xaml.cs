using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinEmailCreationApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async private void RegisterButtonClicked(object sender, EventArgs e)
        {
            if (AreEntriesFilled())
                await DisplayAlert("Error", "Name, Email, and/or password can't be empty", "OK");
            else if (passwordEntry.Text != confirmPasswordEntry.Text)
                await DisplayAlert("Error", "Your passwords aren't the same", "OK");
            else
            {
                LoginPage.AddUser(new User(nameEntry.Text, emailEntry.Text, passwordEntry.Text));
                await DisplayAlert("Important", "Your account has been created", "OK");
            }
        }

        private bool AreEntriesFilled()
        {
            return string.IsNullOrWhiteSpace(nameEntry.Text) || string.IsNullOrWhiteSpace(emailEntry.Text)
                || string.IsNullOrWhiteSpace(passwordEntry.Text);
        }
    }
}