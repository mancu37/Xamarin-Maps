using Xamarin.Forms;

namespace MapApp
{
    public class App : Application
    {
        public App()
        {
            var tabs = new TabbedPage();

            // demonstrates the map control with zooming and map-types
            tabs.Children.Add(new MapPage { Title = "Map/Zoom", Icon = "glyphish_74_location.png" });

            // demonstrates the map control with zooming and map-types
            tabs.Children.Add(new PinPage { Title = "Pins", Icon = "glyphish_07_map_marker.png" });

            // demonstrates the Geocoder class
            tabs.Children.Add(new GeocoderPage { Title = "Geocode", Icon = "glyphish_13_target.png" });

            //// opens the platform's native Map app
            tabs.Children.Add(new MyCustomMap { Title = "Custom Map", Icon = "glyphish_103_map.png" });

            MainPage = tabs;
        }
    }
}
