using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace SwipeViewExample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void onSwipeStarted(System.Object sender, Xamarin.Forms.SwipeStartedEventArgs e)
        {
        }

        void onSwipeEnded(System.Object sender, Xamarin.Forms.SwipeEndedEventArgs e)
        {
        }

        void onSwipeChanging(System.Object sender, Xamarin.Forms.SwipeChangingEventArgs e)
        {
        }

        void onInvoked(System.Object sender, System.EventArgs e)
        {
            SwipeItem swipeItem = (SwipeItem)sender;
            DisplayAlert("Student ", swipeItem.Text.ToString(), "Ok");

            Console.WriteLine("asdasdasdasd");
           
        }
    }
}
