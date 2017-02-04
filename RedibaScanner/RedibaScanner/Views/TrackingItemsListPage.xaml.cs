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
    public partial class TrackingItemsListPage : ContentPage
    {
        public TrackingItemsListPage()
        {
            InitializeComponent();
        }
        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var trackingItem = ((ListView)sender).SelectedItem as TrackingItem;
            if (trackingItem == null)
                return;

            var trackingItemsDetailsPage = new TrackingItemDetailsPage();
            TrackingItemDetailsPageViewModel vm = new TrackingItemDetailsPageViewModel(trackingItem);
            trackingItemsDetailsPage.BindingContext = vm;
            await Navigation.PushAsync(trackingItemsDetailsPage);
        }
    }
}
