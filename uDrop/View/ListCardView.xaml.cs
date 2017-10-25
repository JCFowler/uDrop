using System;
using System.Collections.Generic;
using uDrop.Model;
using uDrop.ViewModel;
using Xamarin.Forms;

namespace uDrop.View
{
    public partial class ListCardView : ContentPage
    {
        public static bool needsRefresh = false;
        CardViewModel vm;

        public ListCardView()
        {
            InitializeComponent();
            vm = new CardViewModel();
            needsRefresh = true;

            ToolbarItems.Add(new ToolbarItem()
            {
                Icon = "ic_add.png",
                Command = new Command(() => Navigation.PushAsync(new CardCreateView()))
            });
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if(needsRefresh)
            {
                _list.IsRefreshing = true;

                _list.ItemsSource = await vm.GetAll();

                _list.IsRefreshing = false;

                needsRefresh = false;
            }

        }

        async void Handle_Refreshing(object sender, System.EventArgs e)
        {
            _list.IsRefreshing = true;

            _list.ItemsSource = await vm.GetAll();

            _list.IsRefreshing = false;
        }

        void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            Card c = (Card)e.SelectedItem;
            DisplayAlert("Card", c.firstLast + " " + c.phone + " " + c.email + " " + c.company + " " + c.title, "Ok");
        }
    }
}

