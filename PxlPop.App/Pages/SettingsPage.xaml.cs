using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Core;
using System.Threading;

namespace PxlPop.App.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
	}

    private void OnDarkModeToggled(object sender, ToggledEventArgs e)
    {
        if (darkThemeSwitch.IsToggled)
        {
            Application.Current!.UserAppTheme = AppTheme.Dark;
        }
        else
        {
            Application.Current!.UserAppTheme = AppTheme.Light;
        }
    }

    private void OnPageAppearing(object sender, EventArgs e)
    {
        switch (Application.Current!.UserAppTheme)
        {
            case AppTheme.Dark:
                darkThemeSwitch.IsToggled = true;
                break;
            default:
                darkThemeSwitch.IsToggled = false;
                break;
        }
    }

    private async void OnNotificationsToggled(object sender, ToggledEventArgs e)
    {
        string text = "Nieuwe instellingen werden toegepast";
        ToastDuration duration = ToastDuration.Short;
        double fontSize = 12;

        var toast = Toast.Make(text, duration, fontSize);

        await toast.Show();
    }
}