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
    public partial class MySpeciesPage : ContentPage
    {
        public MySpeciesPage()
        {
            InitializeComponent();
        }
        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        async void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var mySpecies = ((ListView)sender).SelectedItem as MySpecies;
            if (mySpecies == null)
                return;

            var mySpeciesDetailsPage = new MySpeciesDetailsPage();
            MySpeciesDetailsPageViewModel vm = new MySpeciesDetailsPageViewModel(mySpecies);
            vm.Navigation = mySpeciesDetailsPage.Navigation;
            mySpeciesDetailsPage.BindingContext = vm;
            await Navigation.PushAsync(mySpeciesDetailsPage);
        }
    }
}
