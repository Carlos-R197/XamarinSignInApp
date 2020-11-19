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
    public partial class LoggedPage : MasterDetailPage
    {
        public LoggedPage()
        {
            InitializeComponent();

            this.Master = new MasterPage();
            this.Detail = new NavigationPage(new DetailPage());
        }
    }
}