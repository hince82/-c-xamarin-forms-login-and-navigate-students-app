using Xamarin.Forms.Xaml;
using Xamarin;
using Xamarin.Forms;
using Xamarin.Android;
using Xamarin.Android.Net;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Internals;
using Android.App;

using Android.Content.PM;

using Android.OS;


namespace LoginNavigation.Droid
{
	[Activity (Label = "LoginNavigation.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

            LoadApplication (new LoginNavigation.App());
		}
	}
}

