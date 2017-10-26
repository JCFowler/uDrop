using System;
using System.Collections.Generic;
using uDrop.Model;
using uDrop.ViewModel;
using Xamarin.Forms;

namespace uDrop.View
{
    public partial class CardSingleView : ContentPage
    {
        CardViewModel vm;
        Card selectedCard;
        public static bool needsRefreshing;

        public CardSingleView()
        {
            InitializeComponent();
            vm = new CardViewModel();
            selectedCard = null;
        }

        public CardSingleView(Card c)
        {
            InitializeComponent();
            vm = new CardViewModel();
            selectedCard = null;

            selectedCard = c;
            BindingContext = selectedCard;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            if(needsRefreshing) {
                _loading.IsVisible = true;

                selectedCard = await vm.GetByKey(selectedCard.id);
                needsRefreshing = false;
                BindingContext = selectedCard;

                _loading.IsVisible = false;
            }
        }

        void Edit_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CardCreateView(selectedCard));
        }

        void Delete_Clicked(object sender, System.EventArgs e)
        {
            vm.Delete(selectedCard);
            ListCardView.needsRefresh = true;
            Navigation.PopAsync();
        }
    }
}
