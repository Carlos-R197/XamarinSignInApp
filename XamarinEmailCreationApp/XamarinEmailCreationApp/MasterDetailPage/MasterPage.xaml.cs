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
    public partial class MasterPage : ContentPage
    {
        public MasterPage()
        {
            InitializeComponent();
        }

        private void HomeButtonClicked(object sender, EventArgs e)
        {

        }

        private void Option1ButtonClicked(object sender, EventArgs e)
        {

        }

        async private void LoginPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}