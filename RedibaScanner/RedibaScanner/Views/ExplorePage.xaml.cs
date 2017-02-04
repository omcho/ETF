using Plugin.Geolocator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RedibaScanner.Views
{
    public partial class ExplorePage : ContentPage
    {
        public ExplorePage()
        {
            var locator = CrossGeolocator.Current;
            InitializeComponent();
        }
    }
}
