using RedibaScanner.Models;
using RedibaScanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RedibaScanner.Views
{
    public partial class MyResultPage : ContentPage
    {
        public MyResultPage()
        {
            InitializeComponent();
        }
        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var myResult = ((ListView)sender).SelectedItem as MyResult;
            if (myResult == null)
                return;
            if (myResult.Name.Equals("Uzorci u analizi"))
            {
                var trackingItemsListPage = new TrackingItemsListPage();
                TrackingItemListPageViewModel vm = new TrackingItemListPageViewModel();
                trackingItemsListPage.BindingContext = vm;
                await Navigation.PushAsync(trackingItemsListPage);
            }
            else if (myResult.Name.Equals("Potvrđene vrste"))
            {
                var mySpeciesPage = new MySpeciesPage();
                MySpeciesPagePageViewModel vm = new MySpeciesPagePageViewModel();
                mySpeciesPage.BindingContext = vm;
                await Navigation.PushAsync(mySpeciesPage);
            }



        }
    }
}
