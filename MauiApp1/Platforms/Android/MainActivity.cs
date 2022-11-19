using Android.App;
using Android.Content.PM;

namespace MauiApp1;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
    protected override void OnResume()
    {
        base.OnResume();

        if (TCS != null)
            TCS.SetResult();
    }

    public static TaskCompletionSource TCS { get; set; } = null;
}