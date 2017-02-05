
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
using RedibaScanner.Views;
using Plugin.Media;

namespace RedibaScanner.ViewModels
{
    public class MySubmitPageViewModel : INotifyPropertyChanged
    {
        public MySubmit SubmitInfo { get; set; }
        private string qRCode;
        public INavigation Navigation { get; set; }

        public ICommand ScanTubeCommand
        {
            get; set;
        }

        public ICommand MySubmitInfoCommand
        {
            get; set;
        }
        public ICommand MySubmitCommand
        {
            get; set;
        }

        public ICommand PictureSpeciesCommand
        {
            get; set;
        }

        public ICommand PictureLocationCommand
        {
            get; set;
        }
        

        public MySubmitPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            ScanTubeCommand = new Command(onScanTubeButton);
            PictureSpeciesCommand = new Command(PictureSpecies);
            PictureLocationCommand = new Command(PictureLocation);
            MySubmitInfoCommand = new Command(MySubmitInfo);
            MySubmitCommand = new Command(MySubmit);
            SubmitInfo = new MySubmit();
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
                    QRCode = "QR Code, Tuba: "+result.Text;
                    await App.Current.MainPage.DisplayAlert("Skeniranje uspješno", "Uspješno ste skenirali QRCode!", "Ok");
                    //await DisplayAlert("Scanned Barcode", result.Text, "OK");
                });
            };
            Navigation.PushAsync(scanPage);

        }
        async void PictureSpecies()
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await App.Current.MainPage.DisplayAlert("Nema kamere", "Kamera nedostupna!", "OK");
                return;
            }
            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "RedibaScannerPictures",
                Name = System.DateTime.Now.ToString() + ".jpg",
                SaveToAlbum = true
            });
            if (file == null)
                return;
            else
            {
                SubmitInfo.SpeciesImage.ImageLocation = file.Path;
            }
            await App.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno odabrana slika vrste!", "OK");
        }
        
        async void PictureLocation()
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await App.Current.MainPage.DisplayAlert("Nema kamere", "Kamera nedostupna!", "OK");
                return;
            }
            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "RedibaScannerPictures",
                Name = System.DateTime.Now.ToString() + ".jpg",
                SaveToAlbum = true
            });
            if (file == null)
                return;
            else {
                SubmitInfo.LocationImage.ImageLocation = file.Path;
            }
            await App.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno odabrana slika lokacije!", "OK");

        }
        async void MySubmit()
        {

            var result = await App.Current.MainPage.DisplayAlert("Spašavanje", "Jeste li sigurni?", "Da", "Ne");
            if (!result)
                return;
            else
            {
                await App.Current.MainPage.DisplayAlert("Uspjeh", "Uspješno ste poslali svoju vrstu na identifikaciju!", "OK");
                await Navigation.PopAsync();
            }
            
        }

        void MySubmitInfo()
        {
            MySubmitInfoPage a = new MySubmitInfoPage();
            MySubmitInfoPageViewModel vm = new MySubmitInfoPageViewModel(Navigation, this);
            a.BindingContext = vm;
            Navigation.PushAsync(a);
            //DisplayAlert("Naslov", "Joj","Idemooo");
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
        public string Kingdom
        {
            get { return SubmitInfo.Kingdom; }
            set
            {
                if (qRCode != value)
                {
                    SubmitInfo.Kingdom = value;
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
