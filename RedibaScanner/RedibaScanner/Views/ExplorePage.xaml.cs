using Plugin.Geolocator;
using RedibaScanner.Models;
using RedibaScanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace RedibaScanner.Views
{
    public partial class ExplorePage : ContentPage
    {
        public ExplorePage()
        {
            InitializeComponent();
            Button button = new Button
            {
                Text = "Click Me!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
           
            var map = new Map(
           MapSpan.FromCenterAndRadius(
                   new Position(37, -122), Distance.FromMiles(0.3)))
            {
                IsShowingUser = true,
                HeightRequest = 100,
                WidthRequest = 960,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            map.MapType = MapType.Hybrid;

            //var positionPin = new Position(position.Latitude + 0.0001, position.Longitude); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Generic,
                Position = new Position(37, -122),
                Label = "Babooon",
                Address = "Babooon"
            };
            SpeciesSearchInfo species = new SpeciesSearchInfo
            {
                Name = "Baboon Baboonos",
                LocationImage = new CustomImage()
                {
                    Url = "http://www.drodd.com/images13/world-map12.jpg",
                    ShortDesc = "Lokacija"
                },
                Location = "Jigokudani, u prijevodu “Dolina Pakla”, se nalazi u Yamanouchiu, Shimotakai Distrikt, u Japanu, a područje je poznato po svojoj surovoj klimi, surovom krajoliku, termalnim izvorima – i majmunima. Park je najpoznatiji po svojoj populaciji japanskih makaki majmuna.",
                Hierarchy = "Arthropoda, Malacostraca, Isopoda, Philosciidae, Philoscia, Philoscia muscorum",
                RecordsAvailableText = "Dostupno bilješki: 87514",
                PercentPublicText = "Javno: 34%",
                SpeciesCollectedText = "Sakupljeno vrsta: 301",
                Description = "Majmun je pojam čije se tomačenje na mnogim svjetskim jezicima bitno razlikuje od onog na Engleskom. Za sve repate majmune, Englezi imaju naziv monkey, koji se kod nas prevodi kao majmun, a diferenciraju naziv bezrepih, velikih majmuna (giboni, orangutani, gorile i čimpanze) imenicom ape. Kod nas je ovo odrednica odnosi na sve životinjske vrste iz sisarskog reda primata.Prema klasičnoj sistematizaciji, red primata se dijeli na dva podreda: u prvu grupu se ubrajaju svi polumajmuni (Prosimii), a u drugu repati majmuni i veliki majmuni, uključujući i čovjekolike majmune i ljude (Anthropoidea). Ovdje termin „majmun“ obuhvata Novog svijeta i majmune Starog svijeta (repate, tj psetolike i čovjekolike majmune, odnosno i širokonosne i uskonosne), uključujući i čovjeka i njegove neposredne pretke",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg",
                Images = new List<CustomImage>() { new CustomImage() {

                            Url="http://www.mojportal.ba/slike/novosti/AAA%20ZANIMLJIVOSTI%202012/covjekoliki-majmun.jpg", ShortDesc="Joj"
                         },
                            new CustomImage() {

                            Url="http://www.simboli.rs/wp-content/uploads/majmun-simbolika-300px.jpg", ShortDesc="Joj2"
                            }
                    }
            };
            button.Clicked += async (sender, e) =>
            {
                SpeciesDetailsPage speciesDetailsPage = new SpeciesDetailsPage();
                speciesDetailsPage.Title = species.Name;
                SpeciesDetailsViewModel vm = new SpeciesDetailsViewModel(species, Navigation);
                speciesDetailsPage.BindingContext = vm;
                await Navigation.PushAsync(speciesDetailsPage);
            };
                pin.Clicked += async (sender, e) =>
             {
                SpeciesDetailsPage speciesDetailsPage = new SpeciesDetailsPage();
                speciesDetailsPage.Title = species.Name;
                SpeciesDetailsViewModel vm = new SpeciesDetailsViewModel(species, Navigation);
                speciesDetailsPage.BindingContext = vm;
                await Navigation.PushAsync(speciesDetailsPage);
            };
            map.Pins.Add(pin);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37, -122), Distance.FromMiles(1)));
            
            //Task a = position(map);
            var stack = new StackLayout { Spacing = 0 };
            stack.Children.Add(map);
            Content = stack;
            
        }

        async Task position(Map map)
        {
            var position = await CrossGeolocator.Current.GetPositionAsync(5000);
            var positionPin = new Position(position.Latitude+0.0001, position.Longitude); // Latitude, Longitude
            var pin = new Pin
            {
                Type = PinType.Generic,
                Position = positionPin,
                Label = "Babooon",
                Address = "Babooon"
            };
            SpeciesSearchInfo species = new SpeciesSearchInfo
            {
                Name = "Baboon Baboonos",
                LocationImage = new CustomImage()
                {
                    Url = "http://www.drodd.com/images13/world-map12.jpg",
                    ShortDesc = "Lokacija"
                },
                Location = "Jigokudani, u prijevodu “Dolina Pakla”, se nalazi u Yamanouchiu, Shimotakai Distrikt, u Japanu, a područje je poznato po svojoj surovoj klimi, surovom krajoliku, termalnim izvorima – i majmunima. Park je najpoznatiji po svojoj populaciji japanskih makaki majmuna.",
                Hierarchy = "Arthropoda, Malacostraca, Isopoda, Philosciidae, Philoscia, Philoscia muscorum",
                RecordsAvailableText = "Dostupno bilješki: 87514",
                PercentPublicText = "Javno: 34%",
                SpeciesCollectedText = "Sakupljeno vrsta: 301",
                Description = "Majmun je pojam čije se tomačenje na mnogim svjetskim jezicima bitno razlikuje od onog na Engleskom. Za sve repate majmune, Englezi imaju naziv monkey, koji se kod nas prevodi kao majmun, a diferenciraju naziv bezrepih, velikih majmuna (giboni, orangutani, gorile i čimpanze) imenicom ape. Kod nas je ovo odrednica odnosi na sve životinjske vrste iz sisarskog reda primata.Prema klasičnoj sistematizaciji, red primata se dijeli na dva podreda: u prvu grupu se ubrajaju svi polumajmuni (Prosimii), a u drugu repati majmuni i veliki majmuni, uključujući i čovjekolike majmune i ljude (Anthropoidea). Ovdje termin „majmun“ obuhvata Novog svijeta i majmune Starog svijeta (repate, tj psetolike i čovjekolike majmune, odnosno i širokonosne i uskonosne), uključujući i čovjeka i njegove neposredne pretke",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg",
                Images = new List<CustomImage>() { new CustomImage() {

                            Url="http://www.mojportal.ba/slike/novosti/AAA%20ZANIMLJIVOSTI%202012/covjekoliki-majmun.jpg", ShortDesc="Joj"
                         },
                            new CustomImage() {

                            Url="http://www.simboli.rs/wp-content/uploads/majmun-simbolika-300px.jpg", ShortDesc="Joj2"
                            }
                    }
            };
            pin.Clicked += (sender, e) =>
            {
                var speciesDetailsPage = new SpeciesDetailsPage();
                speciesDetailsPage.Title = species.Name;
                SpeciesDetailsViewModel vm = new SpeciesDetailsViewModel(species, this.Navigation);
                speciesDetailsPage.BindingContext = vm;
                Navigation.PushAsync(speciesDetailsPage);
            };
            map.Pins.Add(pin);
            map.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37, -122), Distance.FromMiles(1)));
        }
    }
}
