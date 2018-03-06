using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Forms.Maps;

namespace MapApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyCustomMap : ContentPage
    {
        Geocoder geoCoder;

        public MyCustomMap()
        {
            InitializeComponent();

            geoCoder = new Geocoder();

        }

        async private void btn_Clicked(object sender, EventArgs e)
        {
            var xamarinAddress = txtEntry.Text;

            var approximateLocation = await geoCoder.GetPositionsForAddressAsync(xamarinAddress);

            if(approximateLocation.Any())
            {
                var item = approximateLocation.Single();

                myCustomMap.Pins.Add(new Pin
                {
                    Position = new Position(item.Latitude, item.Longitude),
                    Label = "Ubicacion re loca..."
                });

                myCustomMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(item.Latitude, item.Longitude), Distance.FromKilometers(0.3)));
            }

            
        }
    }
}