using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ViewModels.Model
{
    public class SeoUrlModel
    {
        [JsonProperty("seo_url_full_url")]
        public string FullUrl { get; set; }
    }
}
