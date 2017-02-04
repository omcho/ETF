using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using RedibaScanner.ViewModels;
using RedibaScanner.Repository;
using RedibaScanner.Views;

namespace RedibaScanner
{
    public static class ViewModelLocator
    {
        static SpeciesSearchInfoViewModel speciesSearchInfoVM;
        public static SpeciesSearchInfoViewModel SpeciesSearchInfoViewModel => speciesSearchInfoVM ?? (speciesSearchInfoVM = new SpeciesSearchInfoViewModel());

        static SpeciesDetailsViewModel speciesDetailsVM;
        public static SpeciesDetailsViewModel SpeciesDetailsViewModel
        => speciesDetailsVM ?? (speciesDetailsVM = new SpeciesDetailsViewModel(SpeciesRepository.SpeciesSearchInfoColl[0]));
    }
    public class App : Application
    {
       
        public App()
        {
          

            //MainPage = new Login();
            MainPage = new NavigationPage(new MenuPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
