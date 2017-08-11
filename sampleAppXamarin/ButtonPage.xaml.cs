using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace sampleAppXamarin
{
    public partial class ButtonPage : ContentPage
    {
        public ButtonPage()
        {
            InitializeComponent();
        }

		public void Crash_Clicked(object sender, EventArgs e)
		{
            DisplayAlert(null, "Sample crash sent.", "OK");
		}

		public void Event_Clicked(object sender, EventArgs e)
		{
            DisplayAlert(null, "Event sent.", "OK");
		}

		public void Color_Clicked(object sender, EventArgs e)
		{
            DisplayActionSheet("Send event with color property", "Cancel",null,"Purple","Yellow","Red","Blue");
		}
    }
}
