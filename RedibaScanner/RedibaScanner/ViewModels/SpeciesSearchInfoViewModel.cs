using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using RedibaScanner.Models;
using RedibaScanner.Repository;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections;
using Xamarin.Forms;
using System.Windows.Input;

namespace RedibaScanner.ViewModels
{
    public class SpeciesSearchInfoViewModel: INotifyPropertyChanged
    {
        private string searchBarText;
        private string test;
        private ObservableCollection<Grouping<string, SpeciesSearchInfo>> speciesSearchInfoCollGrouped;
        private IEnumerable<SpeciesSearchInfo> speciesSearchInfoColl;
        public ICommand SearchCommandC { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        

        public SpeciesSearchInfoViewModel()
        {
            SpeciesSearchInfoColl = SpeciesRepository.SpeciesSearchInfoColl;
            SpeciesSearchInfoCollGrouped = SpeciesRepository.SpeciesSearchInfoCollGrouped;
            SearchCommandC = new Command(searchCommand);
        }

        private void searchCommand()
        {
            SpeciesSearchInfoColl = speciesSearchInfoColl.Where(item => item.Name.ToLower().Contains(searchBarText.ToLower()));
        }
        public ObservableCollection<Grouping<string, SpeciesSearchInfo>> SpeciesSearchInfoCollGrouped
        {
            get
            {
                return speciesSearchInfoCollGrouped;
            }
            set
            {
                if (value != null)
                {
                    speciesSearchInfoCollGrouped = value;
                    OnPropertyChanged();
                }
            }
        }


        public IEnumerable<SpeciesSearchInfo> SpeciesSearchInfoColl
        {
            get
            {
                return speciesSearchInfoColl;
            }
            set
            {
                if (value != null)
                {
                    speciesSearchInfoColl = value;
                    OnPropertyChanged();
                }
            }
        }


        public string Test {
            get { return test; }
            set
            {
                if (value != null)
                    test = value;
                OnPropertyChanged();
            }
        }
        
            public string SearchBarText {
            get {return searchBarText;}
            set {
                if (value != null) { 

                    searchBarText = value;
                    //SpeciesSearchInfoColl = getItems(value);
                    //SpeciesSearchInfoColl = speciesSearchInfoColl.Where(item => item.Name.Contains(searchBarText));
                    Test = searchBarText;

                }
            }
            }
        

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public int SpeciesCount => SpeciesSearchInfoColl.Count();
    }
}
