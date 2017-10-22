using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace uDrop.View
{
    public partial class TabbedMain : ContentPage
    {
        public TabbedMain()
        {
            InitializeComponent();
        }

        void Drop_Clicked(object sender, EventArgs e)
        {

            Navigation.PushAsync(new ListCardView());
        }

        void PickedUp_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ListDroppedView());
        }
    }
}
