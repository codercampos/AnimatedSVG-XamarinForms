using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnimatedSVG.Views;
using Xamarin.Forms;

namespace AnimatedSVG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void AutoPlayHandle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new AutoPlayPage());
        }

        public void ManualPlayHandle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ClickPlayPage());
        }
    }
}
