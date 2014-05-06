using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ViewModels.Model
{
    public class BusinessLocationModel
    {
        [JsonProperty("address1")]
        public string Address1 { get; set; }
        [JsonProperty("address2")]
        public string Address2 { get; set; }
        [JsonProperty("city")]
        public string City { get; set; }
        [JsonProperty("country_region")]
        public string Country { get; set; }
        [JsonProperty("latitude")]
        public double Latitude { get; set; }
        [JsonProperty("longitude")]
        public double Longitude { get; set; }
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
        [JsonProperty("zip")]
        public string Zipcode { get; set; }


        public string Locality
        {
            get
            {
                if (Address1 != null && Address1.EndsWith(","))
                    Address1 = Address1.Remove(Address1.Length - 1);
                return Address1!=null ? (Address1.Substring(Address1.LastIndexOf(',') + 1)).Trim() : string.Empty;
            }
            set
            {
            }
        }
    }
}
