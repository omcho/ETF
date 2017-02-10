using RedibaScanner.Helpers;
using RedibaScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace RedibaScanner.ViewModels
{
    public class SpeciesDetailsViewModel
    {
        public SpeciesSearchInfo SpeciesInfo {get; set;}
        public ICommand PictureTapCommand { get; set; }
        public INavigation Navigation { get; set; }
        public ICommand PictureLocationTapCommand { get; set; }

        public SpeciesDetailsViewModel(SpeciesSearchInfo speciesInfo, INavigation navigation)
        {
            SpeciesInfo = speciesInfo;
            //ovde treba dohvatiti speciesInfo, popuniti ga...
            PictureTapCommand = new Command(onTapped);
            PictureLocationTapCommand = new Command(onTappedLocationImage);
            Navigation = navigation;
        }

        void onTapped(object s)
        {
            var image = SpeciesInfo.Images;
            if (image == null)
                return;
            CarouselPage imagePage = new CarouselPage();
            imagePage.Title = "Dodatne slike";
            foreach (var i in image)
            {

                var myImage = new Xamarin.Forms.Image()
                {
                    Source = FileImageSource.FromUri(
            new Uri(i.Url)),
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand
                };

                StackLayout layout = new StackLayout();
                ContentPage p = new ContentPage();
                layout.Children.Add(new PinchToZoomContainer()
                {
                    Content = myImage,
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand
                });

                p.Content = layout;
                p.Title = i.ShortDesc;
                imagePage.Children.Add(p);
            }
            Navigation.PushAsync(imagePage);
        }

        void onTappedLocationImage()
        {
            var image = SpeciesInfo.LocationImage;
            if (image == null)
                return;
            ContentPage imagePage = new ContentPage();
            var myImage = new Xamarin.Forms.Image()
            {
                Source = FileImageSource.FromUri(
        new Uri(image.Url))
            };

            RelativeLayout layout = new RelativeLayout();
            layout.Children.Add(new PinchToZoomContainer() { Content = myImage },
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => { return parent.Width; }),
                Constraint.RelativeToParent((parent) => { return parent.Height; }));
            imagePage.Content = layout;
            imagePage.Title = image.ShortDesc;
            Navigation.PushAsync(imagePage);
        }
    }
}
