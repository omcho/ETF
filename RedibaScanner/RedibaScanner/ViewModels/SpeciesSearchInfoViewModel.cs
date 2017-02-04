using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using RedibaScanner.Models;
using RedibaScanner.Repository;

namespace RedibaScanner.ViewModels
{
    public class SpeciesSearchInfoViewModel
    {
        public ObservableCollection<SpeciesSearchInfo> SpeciesSearchInfoColl { get; set; }
        public ObservableCollection<Grouping<string, SpeciesSearchInfo>> SpeciesSearchInfoCollGrouped { get; set; }

        public SpeciesSearchInfoViewModel()
        {
            SpeciesSearchInfoColl = SpeciesRepository.SpeciesSearchInfoColl;
            SpeciesSearchInfoCollGrouped = SpeciesRepository.SpeciesSearchInfoCollGrouped;
        }

        public int SpeciesCount => SpeciesSearchInfoColl.Count;
    }
}
