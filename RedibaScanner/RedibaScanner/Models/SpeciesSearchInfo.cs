﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedibaScanner.Models
{
    public class SpeciesSearchInfo
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public CustomImage LocationImage { get; set; }
        public string Image { get; set; }
        public List<CustomImage> Images { get; set; } 
        public string NameSort => Name[0].ToString();
        public string Hierarchy { get; set; }
        public int RecordsAvailable { get; set; }
        public string RecordsAvailableText { get; set; }
        public int PercentPublic { get; set; }
        public string PercentPublicText { get; set; }
        public int SpeciesCollected { get; set; }
        public string SpeciesCollectedText { get; set; }

        public static implicit operator SpeciesSearchInfo(ObservableCollection<SpeciesSearchInfo> v)
        {
            throw new NotImplementedException();
        }
    }

}
