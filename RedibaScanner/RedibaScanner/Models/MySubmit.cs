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
        public MySubmit()
        {
            SpeciesImage = new CustomImage();
            LocationImage = new CustomImage();
        }

        public string BarCode { get; set; }
        public CustomImage SpeciesImage { get; set; }
        public CustomImage LocationImage { get; set; }
        public string Location { get; set; }
        public string LocationSubmited { get; set; }
        public string LocationText { get; set; }
        public string Kingdom { get; set; }
        public string KingdomSubmited { get; set; }
        public string KingdomText { get; set; }
        public string Habitat { get; set; }
        public string HabitatSubmited { get; set; }
        public string HabitatText { get; set; }
        public string Species { get; set; }
        public string SpeciesSubmited { get; set; }
        public string SpeciesText { get; set; }
        public string Notes { get; set; }
    }
}
