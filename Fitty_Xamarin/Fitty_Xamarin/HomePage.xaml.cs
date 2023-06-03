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
    public partial class HomePage : ContentPage
    {
        public string Name { get; set; }

        public HomePage(string name)
        {
            InitializeComponent();

            Name = name;
            BindingContext = this;
        }

        private void Button1_Clicked(object sender, EventArgs e)
        {

        }

        private void Button2_Clicked(object sender, EventArgs e)
        {

        }

        private void Button3_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new HydrationAlarm());
        }
    }
}