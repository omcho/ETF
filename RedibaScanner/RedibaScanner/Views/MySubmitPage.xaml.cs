using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedibaScanner.Views;
using Xamarin.Forms;
using RedibaScanner.ViewModels;
using ZXing.Net.Mobile.Forms;

namespace RedibaScanner
{
    public partial class MySubmitPage : ContentPage
    {

        void TubeScanner(object sender, System.EventArgs e) {
            var scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                // Stop scanning
                scanPage.IsScanning = false;

                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    await DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };
            Navigation.PushAsync(scanPage);
            //DisplayAlert("Naslov", "Joj","Idemooo");
        }

        void Explore(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new ExplorePage());
            //DisplayAlert("Naslov", "Joj","Idemooo");
        }

        void MyResult(object sender, System.EventArgs e)
        {
            MyResultPage a = new MyResultPage();
            MyResultPageViewModel vm = new MyResultPageViewModel();
            a.BindingContext = vm;
            Navigation.PushAsync(a);
            //DisplayAlert("Naslov", "Joj","Idemooo");
        }

        void MySubmit(object sender, System.EventArgs e)
        {
            MyResultPage a = new MyResultPage();
            //MyResultPageViewModel vm = new MyResultPageViewModel();
            //a.BindingContext = vm;*/
            Navigation.PushAsync(a);
            //DisplayAlert("Naslov", "Joj","Idemooo");
        }
        public MySubmitPage()
        {
            InitializeComponent();
        }
    }
}
