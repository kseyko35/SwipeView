using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SwipeViewExample.Models;
using SwipeViewExample.ServiceManager;
using Xamarin.Forms;

namespace SwipeViewExample.Views
{
    public partial class PersonListPage : ContentPage
    {
        public IList<Result> list = new ObservableCollection<Result>();
        Provider provider = new Provider(); 
        public PersonListPage()
        {
            InitializeComponent();
            this.BindingContext = list;
        }

        private async void  OnClicked(System.Object sender, System.EventArgs e)
        {
            list.Clear();
            var result = await provider.GetPersons();
             foreach(var item in result.results)
            {
                list.Add(item);
                
            }
             
             

        }

        void OnDelete(System.Object sender, System.EventArgs e)
        {
            var item = (SwipeItem)sender;
            var param = (Result)item.CommandParameter;
            list.Remove(param);
        }
    }
}
