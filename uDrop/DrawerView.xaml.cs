using System;
using System.Collections.Generic;
using uDrop.View;
using Xamarin.Forms;

namespace uDrop
{
    public partial class DrawerView : MasterDetailPage
    {
        public MainView main = new MainView();
        public DrawerView()
        {
            InitializeComponent();

            //main = new MainPage();
            Detail = new NavigationPage(main);

            menuList.ItemsSource = new string[] {
                "Home",
                "Cards",
                "Contacts",
                "History",
                "Returned Cards",
                "Pick Up",
                "Settings",
                "Log Out",
                "Test"
            };

        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            menuList.HeightRequest = 2 * 100;
        }

        void Item_Clicked(object sender, SelectedItemChangedEventArgs e)
        {
            var current = Detail.Navigation.NavigationStack[0].GetType().Name;

            switch (e.SelectedItem.ToString())
            {
                case "Home":
                    main.SwitchPage(1);
                    //if (current == "MainPage")
                    //    main.SwitchPage(1);
                    //else
                    //Detail = new NavigationPage(new MainPage(1));
                    break;
                case "Cards":
                    main.SwitchPage(2);
                    //Detail = new NavigationPage(main);
                    break;
                case "Contacts":
                    main.SwitchPage(0);
                    //Detail = new NavigationPage(new MainPage(0));
                    break;
                case "History":
                    DisplayAlert("In Progress1", "", "Cancel");
                    break;
                case "Returned Cards":
                    DisplayAlert("In Progress1", "", "Cancel");
                    break;
                case "Pick Up":
                    Detail.Navigation.PushAsync(new ListDroppedView());
                    break;
                case "Settings":
                    Detail.Navigation.PushAsync(new SettingsView());
                    break;
                case "Log Out":
                    DisplayAlert("In Progress1", "", "Cancel");
                    break;
                case "Test":
                    Detail.Navigation.PushAsync(new Test());
                    break;
            }
            IsPresented = false;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new ListCardView());
            IsPresented = false;
        }
    }
}
