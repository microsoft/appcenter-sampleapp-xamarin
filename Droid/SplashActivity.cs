using Android.App;
using Android.OS;

namespace sampleAppXamarin.Droid
{
    [Activity(Theme = "@style/Theme.Splash", MainLauncher = true, NoHistory = true)]
    public class SplashActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            this.StartActivity(typeof(MainActivity));
        }
    }
}
