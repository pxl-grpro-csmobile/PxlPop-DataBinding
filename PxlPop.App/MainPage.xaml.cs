using MauiIcons.Core;
using PxlPop.App.Pages;

namespace PxlPop.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            _ = new MauiIcon();
        }


        private async void OnSettingsClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(SettingsPage), true);
        }

        private async void OnPageLoaded(object sender, EventArgs e)
        {
            await Task.WhenAny(
                pxlLogo.FadeToAsync(1, 3000),
                pxlLogo.RotateToAsync(360, 3000));
        }
    }

}
