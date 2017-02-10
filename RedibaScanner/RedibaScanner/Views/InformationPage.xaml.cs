using RedibaScanner.Models;
using RedibaScanner.Repository;
using RedibaScanner.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RedibaScanner.Views
{
    public partial class InformationPage : ContentPage
    {
        public InformationPage()
        {
            InitializeComponent();
            BindingContext = new SpeciesSearchInfoViewModel();
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var speciesDetails = ((ListView)sender).SelectedItem as SpeciesSearchInfo;
            if (speciesDetails == null)
                return;
            /*
            //speciesDetails = SpeciesRepository.SpeciesSearchInfoColl as ObservableCollection<SpeciesSearchInfo>;
            ObservableCollection<SpeciesSearchInfo>  SpeciesSearchInfoColl = new ObservableCollection<SpeciesSearchInfo>();
            SpeciesSearchInfoColl.Add(new SpeciesSearchInfo
            {
                Name = "Baboon",
                Description = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/f/fc/Papio_anubis_%28Serengeti%2C_2009%29.jpg/200px-Papio_anubis_%28Serengeti%2C_2009%29.jpg",
                Images = new List<string>() { "IDemo", "Dalje", "Dalje 23" }
            });

            SpeciesSearchInfoColl.Add(new SpeciesSearchInfo
            {
                Name = "Capuchin Monkey",
                Description = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.",
                Image = "http://upload.wikimedia.org/wikipedia/commons/thumb/4/40/Capuchin_Costa_Rica.jpg/200px-Capuchin_Costa_Rica.jpg",
                Images = new List<string>() { "IDemo", "Dalje", "Dalje 23" }
            });


            */
            
            var speciesDetailsPage = new SpeciesDetailsPage();
            SpeciesDetailsViewModel vm = new SpeciesDetailsViewModel(speciesDetails, Navigation);
            speciesDetailsPage.BindingContext = vm;
            await Navigation.PushAsync(speciesDetailsPage);
        }
    }
}
