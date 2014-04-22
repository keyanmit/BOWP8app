using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ViewModels.Model
{
    public class BusinessModel
    {
        [JsonProperty("business_id")]
        public string BusinessId { get; set; }
        [JsonProperty("locations")]
        public List<LocationModel> Locations { get; set; }
        [JsonProperty("name")]
        public string BusinessName { get; set; }
        [JsonProperty("provider_business_id")]
        public string ProviderBusinessId { get; set; }

        //view model context

        public LocationModel Location
        {
            get
            {
                return Locations.FirstOrDefault();
            }
        }
    }
}
