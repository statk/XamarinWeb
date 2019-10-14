using System.ComponentModel;
using Xamarin.Forms;
using XamarinWeb.Shared;

namespace XamarinWeb
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private BestViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            viewModel = new BestViewModel();
        }
    }
}
