using SwipeViewExample.Views;
using Xamarin.Forms;

namespace SwipeViewExample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new PersonListPage(); 
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
