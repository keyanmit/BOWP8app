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
        public List<BusinessLocationModel> Locations { get; set; }
        [JsonProperty("name")]
        public string BusinessName { get; set; }
        [JsonProperty("provider_business_id")]
        public string ProviderBusinessId { get; set; }

        //view model context

        public BusinessLocationModel Location
        {
            get
            {
                return Locations.FirstOrDefault();
            }
        }
    }
}
