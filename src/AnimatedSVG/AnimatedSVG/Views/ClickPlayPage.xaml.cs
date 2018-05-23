using System.Windows.Input;
using Xamarin.Forms;

namespace AnimatedSVG.Views
{
    public partial class ClickPlayPage : ContentPage
    {
        public ICommand ClickedCommand { get; private set; }
        public ClickPlayPage()
        {
            // Assign commands before view is created
            ClickedCommand = new Command((obj) => OnClickedCommand());

            InitializeComponent();
        }

        private void OnClickedCommand()
        {
            animationView.Play();
        }
    }
}
