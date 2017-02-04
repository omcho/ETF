
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
assa
namespace RedibaScanner.ViewModels
{
    public class MySpeciesDetailsPageViewModel : INotifyPropertyChanged
    {
        public MySpeciesDetails species { get; set; }
        public List<string> listaa { get; set; }
        public INavigation Navigation { get; set; }

        

        public event PropertyChangedEventHandler PropertyChanged;

        // configure the TapCommand with a method
        
        void OnTapped(object s)
        {
            var image = s as Models.CustomImage;
            if (image == null)
                return;
            ContentPage imagePage = new ContentPage();
            var myImage = new Xamarin.Forms.Image()
            {
                Source = FileImageSource.FromUri(
        new Uri(image.Url))
            };

            RelativeLayout layout = new RelativeLayout();

            layout.Children.Add(myImage,
                Constraint.Constant(0),
                Constraint.Constant(0),
                Constraint.RelativeToParent((parent) => { return parent.Width; }),
                Constraint.RelativeToParent((parent) => { return parent.Height; }));

            imagePage.Content = layout;
            imagePage.Title = image.ShortDesc;
            Navigation.PushAsync(imagePage);
        }


        public MySpeciesDetailsPageViewModel(MySpecies mySpecies)
        {
            
        listaa = new List<string>() { "asss", "sddd" };
            //dobavljanje podataka
            species = new MySpeciesDetails()
            {
                FullName = "Elephantus",
                BarCode = "AAAACCCTAAACCGGGGCCAAACCGGGGACCCTAAACCAAACCGG",
                QRCodeID = "ASD-334-1",
                AdditionalImages = new List<CustomImage>() {
                    new CustomImage() {Url ="http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                    ShortDesc ="Opis",
                    PictureTapCommand = new Command(OnTapped)
        },
                    new CustomImage() {Url ="http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                    ShortDesc ="Opis",
                    PictureTapCommand = new Command(OnTapped)
                    }
                },
                LocationSubmited = "Urbana",
                Kingdom = "Životinja",
                Notes = "Nađen je u gradskom parku",
                HierarchyText = "Nivo 1, Nivo 2, Nivo 3",
                Information = "Slonovi su veliki sisari iz porodice Elephantidae (od lat. elefantus - slon) a spadaju u red Proboscidea (surlaša). Obično se razlikuju dva roda slonova afrički slon (Loxodonta africana) i azijski slon (Elephas maximus), mada postoje neki dokazi da su afrički savanski slon i afrički šumski slon dvije različite vrste (L. africana i L. cyclotis, respektivno). Slonovi su rašireni širom podsaharske Afrike i južne i jugoistočne Azije. Porodica Elephantidae je jedina preživjela porodica iz reda surlaša; druge, danas izumrle vrste iz ovog roda su bile mamuti i mastodonti. Mužjak afričkog slona je najveća kopnena životinja i može doseći visinu od 4 m i težinu od 7 tona. Svi slonovi imaju nekoliko karakterističnih osobina, od koji su najuočljiviji dugo debelo rilo zvano surla, kojim slonovi uzimaju vodu, dišu i dohvataju hranu i predmete. Njihovi sjekutići su narasli u kljove koje mogu služiti kao oružje protiv grabežljivaca ili kao alat za pomjeranje objekata ili kopanje. Svojim velikim ušima mogu mahati čime pomažu u snižavanju temperature tijela. Afrički slonovi imaju veće uši i konkavna leđa dok azijski slonovi imaju manje uši i konveksna ili ravna leđa.",
                Images = new List<Models.CustomImage>() {
                    new CustomImage() {Url ="http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                    ShortDesc ="Opis",
                    PictureTapCommand = new Command(OnTapped)
                    },
                    new CustomImage() {Url ="http://upload.wikimedia.org/wikipedia/commons/thumb/8/83/BlueMonkey.jpg/220px-BlueMonkey.jpg",
                    ShortDesc ="Opis",
                    PictureTapCommand = new Command(OnTapped)
                    }
                },
                LocationText = "Slonovi se mogu pronaći u - Africi \n -Aziji",
                RecordsAvailableText = "65 dostupnih primjeraka",
                PercentPublicText = "81% je javno"
            };


        }
    }
}
