using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using ViewModels.Model;
using BOWP8app.Adapters;

namespace BOWP8app.PhoneServices
{
    public class CompasServiceDefaults
    {
        public static uint NavigatorAccuracy = 300;
        public static uint NavigatorWaitTime = 2;
    }

    public class GeolocationEventArgs
    {
        public DeviceLocationModel Location { get; set; }

        public GeolocationEventArgs(Geoposition loc)
        {
            Location = LocationServicesAdapter.GetLocationModel(loc);
        }
    }

    public class CompasService
    {
        public DeviceLocationModel DeviceLocation { get; private set; }

        private Geolocator Compas;

        public delegate void CompasServiceEventHandler(object sender, GeolocationEventArgs args);
        public CompasServiceEventHandler OnSuccess, OnFailure;

        public void GetDeviceLocationAsync()
        {
            Compas.GetGeopositionAsync(TimeSpan.FromSeconds(CompasServiceDefaults.NavigatorAccuracy), TimeSpan.FromSeconds(CompasServiceDefaults.NavigatorWaitTime))
                .Completed += GeolocationReadComplete;
        }

        private void GeolocationReadComplete(Windows.Foundation.IAsyncOperation<Geoposition> asyncInfo, Windows.Foundation.AsyncStatus asyncStatus)
        {
            if (asyncStatus == Windows.Foundation.AsyncStatus.Completed)
            {
                var deviceLocation = (Geoposition)asyncInfo.GetResults();               
                OnSuccess(this,new GeolocationEventArgs(deviceLocation));
            }

            OnFailure(this,new GeolocationEventArgs(null));
        }
    }
}
