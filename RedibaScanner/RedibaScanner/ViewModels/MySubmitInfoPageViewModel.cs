
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
    public class MySubmitInfoPageViewModel : INotifyPropertyChanged
    {

        public MySubmitPageViewModel MySubmit { get; set; }
        public List<string> Kingdom { get; set; }
        public List<string> Habitat { get; set; }
        //public MySubmit MySubmitInfo { get; }
        private string qRCode;
        public INavigation Navigation;
        public ICommand SubmitCommand { get; set;  }
        
        public MySubmitInfoPageViewModel(INavigation navigation, MySubmitPageViewModel mySubmit)
        {
            Navigation = navigation;
            SubmitCommand = new Command(submitButton);
            MySubmit = mySubmit;
            Kingdom = new List<string>() {
                "Zivotinja",
                "Insekt",
                "Biljka"
            };

            Habitat = new List<string>() {
                "Urbano",
                "Ruralno",
                "Šuma",
                "Voda"
            };
        }

        async void submitButton()
        {
            var result =await App.Current.MainPage.DisplayAlert("Spašavanje","Jeste li sigurni?", "Da", "Ne");
            if (!result)
                return;
            else {
                MySubmit.SubmitInfoTaken = Color.LightGreen;
                await Navigation.PopAsync();
            }
        }


        public string KingdomSelected {
            get { return MySubmit.SubmitInfo.Kingdom; }
            set
            {
                if (MySubmit.SubmitInfo.Kingdom != value)
                {
                    MySubmit.Kingdom = value;
                    OnPropertyChanged();
                }
            }

        }

        public string HabitatSelected
        {
            get { return MySubmit.SubmitInfo.Habitat; }
            set
            {
                if (MySubmit.SubmitInfo.Habitat != value)
                {
                    MySubmit.SubmitInfo.Habitat = value;
                    OnPropertyChanged();
                }
            }

        }
        public string Notes
        {
            get { return MySubmit.SubmitInfo.Notes; }
            set
            {
                if (MySubmit.SubmitInfo.Notes != value)
                {
                    MySubmit.SubmitInfo.Notes = value;
                    OnPropertyChanged();
                }
            }
        }
        public string Species
        {
            get { return MySubmit.SubmitInfo.Species; }
            set
            {
                if (MySubmit.SubmitInfo.Species != value)
                {
                    MySubmit.SubmitInfo.Species = value;
                    OnPropertyChanged();

                }
            }

        }
        
        
        public string QRCode { get { return qRCode; }
            set
            {
                if (qRCode != value)
                {
                    qRCode = value;
                    //SubmitInfo.BarCode = value;
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
