using System;
using System.Collections.Generic;
using uDrop.ViewModel;
using Xamarin.Forms;

namespace uDrop.View
{
    public partial class ListCardView : ContentPage
    {
        CardViewModel vm;

        public ListCardView()
        {
            InitializeComponent();
            vm = new CardViewModel();
            cardsList.ItemsSource = vm.cards;

        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var page = new ListCardView();
            NavigationPage.SetBackButtonTitle(page, "WTF");
            Navigation.PushAsync(page);
        }
    }
}

