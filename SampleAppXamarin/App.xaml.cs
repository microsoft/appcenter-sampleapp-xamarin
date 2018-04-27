using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace SampleAppXamarin
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();
            MainPage = new ButtonPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=<APP SECRET HERE>;" +
                            "ios=<APP SECRET HERE>;" +
                            "uwp=<APP SECRET HERE>;",
                typeof(Analytics), typeof(Crashes));
        }
    }
}
