using RedibaScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedibaScanner.ViewModels
{
    public class TrackingItemDetailsPageViewModel
    {
        public List<TrackingItemDetails> list { get; set; }

        public TrackingItemDetailsPageViewModel(TrackingItem trackingItem)
        {
            //dobavljanje podataka
            list = new List<TrackingItemDetails>();
            list.Add(new TrackingItemDetails() { State = "Uzorak u pripremi", Status = 1, Description = "Uzorak se nalazi u pripremi" });
            list.Add(new TrackingItemDetails() { State = "Izolacija DNK", Status = 2, Description = "DNK se izolira" });
            list.Add(new TrackingItemDetails() { State = "Sekvenciranje DNK", Status = 3, Description = "DNK se sekvencira" });
            list.Add(new TrackingItemDetails() { State = "Identifikacija vrste", Status = 4, Description = "Vrši se identifikacija vrste" });
            
        }
    }
}
