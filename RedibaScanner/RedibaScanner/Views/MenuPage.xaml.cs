using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedibaScanner.Views;
using Xamarin.Forms;
using RedibaScanner.ViewModels;
using Plugin.Geolocator;

namespace RedibaScanner
{
    public partial class MenuPage : ContentPage
    {
        void Idemo(object sender, System.EventArgs e) {
            Navigation.PushAsync(new InformationPage());
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
            var a = new MySubmitPage();
            MySubmitPageViewModel vm = new MySubmitPageViewModel(a.Navigation);
            a.BindingContext = vm;
            Navigation.PushAsync(a);
            //DisplayAlert("Naslov", "Joj","Idemooo");
        }
        public MenuPage()
        {
            InitializeComponent();
        }
    }
}
