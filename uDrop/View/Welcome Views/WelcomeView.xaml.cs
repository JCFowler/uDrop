using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace uDrop.View.WelcomeViews
{
    public partial class WelcomeView : ContentPage
    {
        private SaveControllerInterface save;

        public WelcomeView()
        {
            InitializeComponent();

            save = DependencyService.Get<SaveControllerInterface>();
            if (save != null)
            {
                string name = save.GetSavedName();

                test.Text = name;
            }
        }

        void Continue_Clicked(object sender, System.EventArgs e)
        {
            save = DependencyService.Get<SaveControllerInterface>();
            if (save != null)
            {
                save.SetSavedName(eName.Text);
            }

            Navigation.PushModalAsync(new AccountSetupView());
        }

        void Skip_Clicked(object sender, System.EventArgs e)
        {
            save = DependencyService.Get<SaveControllerInterface>();
            if (save != null)
            {
                save.SetSavedName(eName.Text);
            }

            Navigation.PushModalAsync(new DrawerView());
        }
    }
}
