using RedibaScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedibaScanner.ViewModels
{
    public class TrackingItemListPageViewModel
    {
        public List<TrackingItem> list { get; set; }

        public TrackingItemListPageViewModel()
        {
            //dobavljanje podataka
            list = new List<TrackingItem>();
            list.Add(new TrackingItem() { QRCodeID = "Asdd 33", Note="Mislim da je slon"});
            list.Add(new TrackingItem() { QRCodeID = "Asdd 22233", Note = "Mislim da je tigar" });


        }
    }
}
