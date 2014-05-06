using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Devices.Geolocation;
using ViewModels.Model;

namespace BOWP8app.Adapters
{
    public class LocationServicesAdapter
    {
        public static DeviceLocationModel GetLocationModel(Geoposition Position)
        {
            return Position != null ? new DeviceLocationModel
            {
                Latitude = Position.Coordinate.Latitude,
                Longitude = Position.Coordinate.Longitude,
                City = string.Empty,
                Country = string.Empty
            } : null;
        }
    }
}
