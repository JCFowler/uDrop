using System;
using Xamarin.Forms;

namespace uDrop
{
    public class GlobalFunctions
    {
		public static Page setNavigation(Page page)
		{

			NavigationPage.SetBackButtonTitle(page, "Back");

			return page;
		}
    }
}
