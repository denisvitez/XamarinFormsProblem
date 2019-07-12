using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Subpage : ContentPage
    {
        public Subpage()
        {
            InitializeComponent();
            BtnOpen.Clicked += async (s, e) =>
            {
                await Navigation.PushAsync(new HelpPage());
            };
            ManualLocationButton.Clicked += async (s, e) =>
            {
                await Navigation.PushAsync(new HelpPage());
            };
        }
    }
}