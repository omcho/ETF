using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedibaScanner.Models
{
    public class MySpeciesDetails
    {
        public string FullName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string Species { get; set; }
        public string Habitat { get; set; }
        public string Kingdom { get; set; }
        public string QRCodeID { get; set; }

        public string BarCode { get; set; }
        public List<CustomImage> Images { get; set; }
        public List<CustomImage> AdditionalImages { get; set; }
        public List<string> Location { get; set; }
        public string LocationSubmited { get; set; }
        public string LocationText { get; set; }
        public CustomImage LocationMap { get; set; }
        public string Information { get; set; }
        public List<string> Hierarchy { get; set; }
        public string HierarchyText { get; set; }
        public int RecordsAvailable { get; set; }
        public string RecordsAvailableText { get; set; }
        public int PercentPublic { get; set; }
        public string PercentPublicText { get; set; }
        public int SpeciesCollected { get; set; }
        public string SpeciesCollectedText { get; set; }

    }
}
