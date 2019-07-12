using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        Page Instance = null;
        public MainPage()
        {
            InitializeComponent();
            BtnOpenPage.Clicked += async (s, e) =>
            {
                if (Instance == null)
                    Instance = new Subpage();
                await Navigation.PushAsync(Instance);
            };
        }
    }
}
