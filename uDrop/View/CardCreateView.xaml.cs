using System;
using System.Collections.Generic;
using uDrop.Model;
using uDrop.ViewModel;
using Xamarin.Forms;

namespace uDrop.View
{
    public partial class CardCreateView : ContentPage
    {
        CardCreateViewModel vm;

        public CardCreateView()
        {
            InitializeComponent();

            vm = new CardCreateViewModel();

            ToolbarItems.Add(new ToolbarItem()
            {
                Icon = "ic_add.png",
                Command = new Command(() => addCard())
            });
        }

        void Add_Clicked(object sender, System.EventArgs e)
        {
            addCard();
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
    }
}
