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
            DisplayAlert("Send a sample crash", "Sample crash sent.", "OK");

        }

        public void Event_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Send a sample event", "Event sent.", "OK");

        }

        public void Color_Clicked(object sender, EventArgs e)
        {
            DisplayActionSheet("Send event with color property", "Cancel", "OK", "Purple", "Yellow", "Red", "Blue");

        }
    }
}
