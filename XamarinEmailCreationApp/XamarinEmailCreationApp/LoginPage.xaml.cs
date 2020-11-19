using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinEmailCreationApp
{
    public partial class LoginPage : ContentPage
    {
        private static List<User> existingUsers = new List<User>();

        public static void AddUser(User user) =>
            existingUsers.Add(user);

        public LoginPage()
        {
            InitializeComponent();
        }


        async private void LoginButtonClicked(object sender, EventArgs e)
        {
            User user = existingUsers.FirstOrDefault(t => t.Email == emailEntry.Text && t.Password == passwordEntry.Text);
            if (user != null)
            {
                await DisplayAlert("Welcome", $"Hello {user.Name} ", "OK");
                emailEntry.Text = "";
                passwordEntry.Text = "";
                await Navigation.PushAsync(new LoggedPage());
            }
            else
            {
                if (string.IsNullOrWhiteSpace(emailEntry.Text) || string.IsNullOrWhiteSpace(passwordEntry.Text))
                    await DisplayAlert("Error", "The entries must be filled", "OK");
                else
                    await DisplayAlert("Error", "The user does not exist", "OK");
            }
        }

        async private void RegisterButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegisterPage(existingUsers));
        }
    }
}
