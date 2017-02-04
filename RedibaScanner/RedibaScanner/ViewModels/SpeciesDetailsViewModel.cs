using RedibaScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedibaScanner.ViewModels
{
    public class SpeciesDetailsViewModel
    {
        public SpeciesSearchInfo SpeciesInfo {get; set;}

        public SpeciesDetailsViewModel(SpeciesSearchInfo speciesInfo)
        {
            SpeciesInfo = speciesInfo;
        }
}
}
