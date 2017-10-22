using Xamarin.Forms;

namespace uDrop
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            SaveControllerInterface sc = DependencyService.Get<SaveControllerInterface>();

            if (sc != null)
            {
                if (sc.GetSavedName() != null && sc.GetSavedName() != "")
                {
                    MainPage = new DrawerView();
                }
                else
                    MainPage = new View.WelcomeViews.WelcomeView();
            }
            else
                MainPage = new View.WelcomeViews.WelcomeView();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
