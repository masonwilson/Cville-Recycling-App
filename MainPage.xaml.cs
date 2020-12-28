using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.GoogleMaps;
using Rg.Plugins.Popup.Services;
using Xamarin.Forms.Internals;

namespace App2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            // methods to request for permissions 
            CheckAndRequestLocationPermission();
            CheckAndRequestLocationPermission1();
            InitializeComponent();

            // methods to add pins to map 
            AddPackageDepot();
            AddIvy();
            AddMcIntire();
            AddPaperSort();
            AddPantops();
            AddNorthsideLibrary();
            AddScottsville();
            AddPackMail();
            AddBlueRidge();
        }
        //request appropriate permissions for location
        public async Task<PermissionStatus> CheckAndRequestLocationPermission()
        {
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>(); // gets status of location when in use permissions in settings
            if (status != PermissionStatus.Granted)
            // until permissions are granted, program waits and does not run the app fully
            {
                status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
            }

            // Additionally could prompt the user to turn on in settings

            return status;
        }
        public async Task<PermissionStatus> CheckAndRequestLocationPermission1()
        {
            // same process as above for location permissions to be granted always 
            var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();
            if (status != PermissionStatus.Granted)
            {
                status = await Permissions.RequestAsync<Permissions.LocationAlways>();
            }

            // Additionally could prompt the user to turn on in settings

            return status;
        }

        // add location - Ivy
        private void AddIvy()
        {
            Pin one = new Pin() // creates new pin on the map
            {
                Label = "Ivy", // name of pin displayed 
                Position = new Position(38.021436330, -78.653405170), // longitude/latitude for pin
                Icon = BitmapDescriptorFactory.FromBundle("Recycle") // icon turned into a recycling sign
            };

            MyMap.Pins.Add(one); // adds pin to map
           
            // map moved to be centered on pin if this one is pushed
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(38.021436330, -78.653405170), Distance.FromKilometers(10)));
            // all pins below follow this same pattern 
        }
        // add location - McIntire
        private void AddMcIntire()
        { 
            Pin two = new Pin()
            {
            Label = "McIntire",
            Position = new Position(38.037457173, -78.479268271),
            Icon = BitmapDescriptorFactory.FromBundle("Recycle")

            };

            MyMap.Pins.Add(two);
            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(38.037457173,-78.479268271), Distance.FromKilometers(10)));
        }
        // add location - Paper Sort
        private void AddPaperSort()
        {
            Pin three = new Pin()
            {
                Label = "Paper Sort Facility",
                Position = new Position(38.036514580, -78.502288057),                
                Icon = BitmapDescriptorFactory.FromBundle("Recycle")

            };

            MyMap.Pins.Add(three);

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(38.036514580, -78.502288057), Distance.FromKilometers(10)));
        }
        // add location - Pantops
        private void AddPantops()
        {
            Pin four = new Pin()
            {
                Label = "Pantops Shopping Center",
                Position = new Position(38.030747000, -78.458578000),
                Icon = BitmapDescriptorFactory.FromBundle("Recycle")

            };

            MyMap.Pins.Add(four);

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(38.030747000, -78.458578000), Distance.FromKilometers(10)));
        }
        // add location - Northside Library
        private void AddNorthsideLibrary()
        {
            Pin five = new Pin()
            {
                Label = "Northside Library",
                Position = new Position(38.083105000, -78.476228000),
                Icon = BitmapDescriptorFactory.FromBundle("Recycle")

            };

            MyMap.Pins.Add(five);

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(38.083105000, -78.476228000), Distance.FromKilometers(10)));
        }
        // add location - Scottsville
        private void AddScottsville()
        {
            Pin six = new Pin()
            {
                Label = "Scottsville Boys and Girls Club",
                Position = new Position(37.797772000, -78.497584000),
                Icon = BitmapDescriptorFactory.FromBundle("Recycle")

            };

            MyMap.Pins.Add(six);

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(37.797772000, -78.497584000), Distance.FromKilometers(10)));
        }
        // add location - Blue Ridge
        private void AddBlueRidge()
        {
            Pin seven = new Pin()
            {
                Label = "Blue Ridge Pack & Ship",
                Position = new Position(38.037016000, -78.487524000),
                Icon = BitmapDescriptorFactory.FromBundle("Recycle")

            };

            MyMap.Pins.Add(seven);

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(38.037016000, -78.487524000), Distance.FromKilometers(10)));
        }
        // add location - Pack Mail
        private void AddPackMail()
        {
            Pin eight = new Pin()
            {
                Label = "Pack 'N' Mail",
                Position = new Position(38.031069000, -78.457226000),
                Icon = BitmapDescriptorFactory.FromBundle("Recycle")

            };

            MyMap.Pins.Add(eight);

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(38.031069000, -78.457226000), Distance.FromKilometers(10)));
        }
        // add location - Package Depot
        private void AddPackageDepot()
        {
            Pin nine = new Pin()
            {
                Label = "Package Depot",
                Position = new Position(38.043800000, -78.512523330),
                Icon = BitmapDescriptorFactory.FromBundle("Recycle")

            };

            MyMap.Pins.Add(nine);

            MyMap.MoveToRegion(MapSpan.FromCenterAndRadius(new Position(38.043800000, -78.512523330), Distance.FromKilometers(10)));
        }
        // transitions between pages
        // waiting for bottom buttons to be pushed then switches pages 
        async void OnList(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListView());
        }
        
        async void OnMap(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
        async void OnProfile(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new profilePage());
        }
       
    }
}
