
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using RedibaScanner.Models;
using ZXing.Net.Mobile.Forms;
using System.Runtime.CompilerServices;

namespace RedibaScanner.ViewModels
{
    public class MySubmitPageViewModel : INotifyPropertyChanged
    {
        public MySubmit SubmitInfo;
        private string qRCode;
        public INavigation Navigation;

        public ICommand ScanTubeCommand
        {
            get; set;
        }

            public MySubmitPageViewModel(INavigation navigation, MySubmit submitInfo)
        {
            Navigation = navigation;
            ScanTubeCommand = new Command(onScanTubeButton);
            SubmitInfo = submitInfo;
        }
        
        void onScanTubeButton () {
            var scanPage = new ZXingScannerPage();
            scanPage.OnScanResult += (result) =>
            {
                // Stop scanning
                scanPage.IsScanning = false;

                // Pop the page and show the result
                Device.BeginInvokeOnMainThread(async () =>
                {
                    await Navigation.PopAsync();
                    QRCode = result.Text;
                    await App.Current.MainPage.DisplayAlert("You have connect to .....!", "Would you like to Clock In at once?", "Ok");
                    //await DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };
            Navigation.PushAsync(scanPage);

        }
        
        public string QRCode { get { return qRCode; }
            set
            {
                if (qRCode != value)
                {
                    qRCode = value;
                    SubmitInfo.BarCode = value;
                    OnPropertyChanged();
                }
            }
            }

        
       
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
