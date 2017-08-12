using System.Collections.Generic;
using Xamarin.Forms;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace sampleAppXamarin
{
    public partial class App : Application
    {

        public App()
        {
            MobileCenter.Start("android=56a4c38c-9003-489d-b04b-c2c547fc23d5;" +
                   "ios=b21e0878-63f9-4fd0-bcbf-94d1760c7f91;",
                   typeof(Analytics), typeof(Crashes));
            MainPage = new ButtonPage();
        }
    }
}
