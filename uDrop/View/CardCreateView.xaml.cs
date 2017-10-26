using System;
using System.Collections.Generic;
using uDrop.Model;
using uDrop.ViewModel;
using Xamarin.Forms;

namespace uDrop.View
{
    public partial class CardCreateView : ContentPage
    {
        CardViewModel vm;
        Card oldCard;

        public CardCreateView()
        {
            InitializeComponent();

            Title = "Create Card";

            vm = new CardViewModel();

            ToolbarItems.Add(new ToolbarItem()
            {
                Icon = "ic_add.png",
                Command = new Command(() => addCard())
            });

            _button.Text = "Add Card";
            _button.Command = new Command(() => addCard());
        }

        public CardCreateView(Card c) 
        {
            InitializeComponent();

            Title = "Edit Card";

            vm = new CardViewModel();
            oldCard = c;

            ToolbarItems.Add(new ToolbarItem()
            {
                Icon = "ic_menu.png",
                Command = new Command(() => editCard())
            });

            _button.Text = "Edit Card";
            _button.Command = new Command(() => editCard());

            _fname.Text = oldCard.fName;
            _lname.Text = oldCard.lName;
            _phone.Text = oldCard.phone;
            _email.Text = oldCard.email;
            _company.Text = oldCard.company;
            _title.Text = oldCard.title;
        }

        void test() {
            DisplayAlert("","","ok");
        }

        void addCard() {
            var card = new Card();
            card.id = "";
            card.fName = _fname.Text;
            card.lName = _lname.Text;
            card.phone = _phone.Text;
            card.email = _email.Text;
            card.company = _company.Text;
            card.title = _title.Text;

            vm.Add(card);

            //Tells View to refresh the list
            ListCardView.needsRefresh = true;
        }

        void editCard() {
            Card newC = new Card();

            newC.id = oldCard.id;
            newC.fName = _fname.Text;
            newC.lName = _lname.Text;
            newC.phone = _phone.Text;
            newC.email = _email.Text;
            newC.company = _company.Text;
            newC.title = _title.Text;

            vm.Edit(newC, oldCard);

            //Tells View to refresh the list
            ListCardView.needsRefresh = true;
            CardSingleView.needsRefreshing = true;

            Navigation.PopAsync();
        }
    }
}
