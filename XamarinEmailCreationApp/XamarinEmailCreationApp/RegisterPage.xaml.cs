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
        IEnumerable<User> existingUsers;

        public RegisterPage(IEnumerable<User> existingUsers)
        {
            InitializeComponent();
            this.existingUsers = existingUsers;
        }

        async private void RegisterButtonClicked(object sender, EventArgs e)
        {
            if (AreEntriesFilled())
                await DisplayAlert("Error", "Name, Email, and/or password can't be empty", "OK");
            else if (passwordEntry.Text != confirmPasswordEntry.Text)
                await DisplayAlert("Error", "Your passwords aren't the same", "OK");
            else
            {
                if (existingUsers.Any(t => t.Email == emailEntry.Text))
                    await DisplayAlert("Error", "That email is alredy in use", "OK");
                else
                {
                    LoginPage.AddUser(new User(nameEntry.Text, emailEntry.Text, passwordEntry.Text));
                    await DisplayAlert("Important", "Your account has been created", "OK");
                }
            }
        }

        private bool AreEntriesFilled()
        {
            return string.IsNullOrWhiteSpace(nameEntry.Text) || string.IsNullOrWhiteSpace(emailEntry.Text)
                || string.IsNullOrWhiteSpace(passwordEntry.Text);
        }
    }
}