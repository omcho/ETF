using RedibaScanner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace RedibaScanner.Views
{
    public partial class MySpeciesDetailsPage : ContentPage
    {
        public MySpeciesDetailsPage()
        {
            InitializeComponent();
            /*AdditionalImagess.ItemSelected += (sender, args) =>
            {
                var image = args.SelectedItem as Models.Image;
                if (image == null)
                    return;
                ContentPage imagePage = new ContentPage();
                var myImage = new Xamarin.Forms.Image()
                {
                    Source = FileImageSource.FromUri(
            new Uri(image.Url))
                };

                RelativeLayout layout = new RelativeLayout();

                layout.Children.Add(myImage,
                    Constraint.Constant(0),
                    Constraint.Constant(0),
                    Constraint.RelativeToParent((parent) => { return parent.Width; }),
                    Constraint.RelativeToParent((parent) => { return parent.Height; }));

                imagePage.Content = layout;
                imagePage.Title = image.ShortDesc;
                Navigation.PushAsync(imagePage);
                //Title = zoo.Name;
            };*/
        }

        void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        => ((ListView)sender).SelectedItem = null;

        void Handle_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var myResult = ((ListView)sender).SelectedItem as MySpeciesDetails;
            if (myResult == null)
                return;
        }

    }
}
