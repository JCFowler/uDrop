using System;
using System.Collections.Generic;
using uDrop.ViewModel;

using Xamarin.Forms;

namespace uDrop.View
{
    public partial class ListDroppedView : ContentPage
    {
        DropViewModel vm;

        public ListDroppedView()
        {
            InitializeComponent();
            vm = new DropViewModel();

            dropsList.ItemsSource = vm.drops;
        }
    }
}
