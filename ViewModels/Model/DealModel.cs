using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ViewModels.Model
{
    public class DealModel
    {
        private string _imageUrl;        

        [JsonProperty("attribution")]
        public string Attribution { get; set; }
        [JsonProperty("business")]
        public BusinessModel Business { get; set; }
        [JsonProperty("currency_code")]
        public string CurrencyCode { get; set; }
        [JsonProperty("currency_symbol")]
        public string CurrencySymbol { get; set; }
        [JsonProperty("title")]        
        public string DealTitle { get; set; }
        [JsonProperty("description")]
        public string DealInfo { get; set; }
        [JsonProperty("end_time")]
        public string EndTime { get; set; }
        [JsonProperty("id")]
        public string DealId { get; set; }
        [JsonProperty("transaction_url")]
        public string TransactionUrl { get; set; }
        [JsonProperty("image_url")]
        public string ImageUrl
        {
            get
            {
                return _imageUrl;
            }
            set
            {
                _imageUrl = value + "&size=4";
            }
        }
        [JsonProperty("restriction")]
        public string Restriction { get; set; }
        [JsonProperty("seo_url")]
        public SeoUrlModel  SeoUrl{ get; set; }
        [JsonProperty("deal_type")]
        public int DealType { get; set; }
    }
}
