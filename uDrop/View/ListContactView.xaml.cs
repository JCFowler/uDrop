using System;
using System.Collections.Generic;
using uDrop.ViewModel;
using Xamarin.Forms;

namespace uDrop.View
{
    public partial class ListContactView : ContentPage
    {
        new ContactViewModel vm;

        public ListContactView()
        {
            InitializeComponent();
            vm = new ContactViewModel();

            contactsList.ItemsSource = vm.contacts;
        }
    }
}
