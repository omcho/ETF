using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace RedibaScanner.Models
{
    public class MySubmit
    {
        public string BarCode { get; set; }
        public CustomImage SpeciesImage { get; set; }
        public CustomImage LocationImage { get; set; }
        public string Location { get; set; }
        public string LocationSubmited { get; set; }
        public string LocationText { get; set; }
        public string Habitat { get; set; }
        public string HabitatSubmited { get; set; }
        public string HabitatText { get; set; }
        public string Species { get; set; }
        public string SpeciesSubmited { get; set; }
        public string SpeciesText { get; set; }
        public string Notes { get; set; }
    }
}
