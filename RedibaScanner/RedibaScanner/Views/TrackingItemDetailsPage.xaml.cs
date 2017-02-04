using RedibaScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RedibaScanner.Views
{
    public partial class TrackingItemDetailsPage : ContentPage
    {
        public TrackingItemDetailsPage()
        {
            InitializeComponent();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var myResult = ((ListView)sender).SelectedItem as TrackingItemDetails;
            if (myResult == null)
                return;
        }
    }
}
