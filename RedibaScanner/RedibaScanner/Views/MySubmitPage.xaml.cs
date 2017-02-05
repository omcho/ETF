using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedibaScanner.Views;
using Xamarin.Forms;
using RedibaScanner.ViewModels;
using ZXing.Net.Mobile.Forms;
using Plugin.Media;

namespace RedibaScanner
{
    public partial class MySubmitPage : ContentPage
    {
        public MySubmitPage()
        {
            InitializeComponent();
        }
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

        async void Explore(object sender, System.EventArgs e)
        {
            if (!CrossMedia.Current.IsCameraAvailable || !CrossMedia.Current.IsTakePhotoSupported)
            {
                await DisplayAlert("No Camera", ":( No camera avaialble.", "OK");
                return;
            }
            var file = await CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions
            {
                Directory = "Sample",
                Name = System.DateTime.Now.ToString()+ ".jpg",
                SaveToAlbum = true  
            });
            if (file == null)
                return;
            await DisplayAlert("File Location", file.AlbumPath, "OK");
            /*ContentPage imagePage = new ContentPage();
            var myImage = new Image() { Aspect = Aspect.AspectFit};
            myImage.Source = ImageSource.FromFile(file.Path);
        
            RelativeLayout layout = new RelativeLayout();

            layout.Children.Add(myImage,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => { return parent.Width; }),
                Constraint.RelativeToParent((parent) => { return parent.Height; }));

            imagePage.Content = layout;
            imagePage.Title = "Test";
            await Navigation.PushAsync(imagePage);*/
        }


        /*image.Source = ImageSource.FromStream(() =>
        {
            var stream = file.GetStream();
            file.Dispose();
            return stream;
        });*/



        //Navigation.PushAsync(new ExplorePage());
        //DisplayAlert("Naslov", "Joj","Idemooo");

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
        
    }
}
