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
            list.Add(new TrackingItem() { QRCodeID = "AEF-456", Note="Mislim da je slon"});
            list.Add(new TrackingItem() { QRCodeID = "AEF-123", Note = "Mislim da je tigar" });


        }
    }
}
