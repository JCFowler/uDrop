using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace uDrop
{
    public partial class MainView : TabbedPage
    {
        //Used only for inital load. Use constructor with string afterwards. 
        public MainView()
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Back");

            //Used to get Tab view to second tab on start. Sets Title. 
            var pages = Children.GetEnumerator();
            CurrentPage = Children[1];
            Title = CurrentPage.Title;

            //Changes title to page title. 
            CurrentPageChanged += CurrentPageHasChanged;
        }

        public MainView(int num)
        {
            InitializeComponent();
            NavigationPage.SetBackButtonTitle(this, "Back");

            CurrentPage = Children[num];
            Title = CurrentPage.Title;
            CurrentPageChanged += CurrentPageHasChanged;
        }

        public void SwitchPage(int num)
        {
            CurrentPage = Children[num];
        }

        protected void CurrentPageHasChanged(object sender, EventArgs e)
        {
            Title = CurrentPage.Title;
        }
    }
}
