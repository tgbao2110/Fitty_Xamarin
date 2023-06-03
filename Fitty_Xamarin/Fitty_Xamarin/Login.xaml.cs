using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Fitty_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Next_Button_Clicked(object sender, EventArgs e)
        {
            var name = txtName.Text;
            if (name == "") { name = "User"; }
            Navigation.PushAsync(new HomePage(name));
        }
    }
}