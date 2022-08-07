using Android.App;
using Android.Content.PM;
using Android.OS;
using Firebase.Analytics;
using testfirebase.Services;

namespace testfirebase;

[Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
public class MainActivity : MauiAppCompatActivity
{
	public MainActivity()
	{
		FirebaseCustomService fire = new FirebaseCustomService();
		fire.EventLogger();
    }

	protected override void OnCreate(Bundle savedInstanceState)
	{
		base.OnCreate(savedInstanceState);

    }
}
