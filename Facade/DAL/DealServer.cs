using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Model;
using ViewModels.ViewModel;
using Facade.Factory;
using Newtonsoft.Json;

namespace Facade.DAL
{
    public class DealServer
    {
        public static async Task<List<DealModel>> GetNearByDeals(DealServerQueryModel model)
        {
            using (var dlClient = new HttpClient())
            {
                var url = ClientUriBuilder.GetDealServerUri(model);
                try
                {
                    var responseString = await dlClient.GetStringAsync(url);
                    var list = JsonConvert.DeserializeObject<List<DealModel>>(responseString);
                    return list;
                }
                catch (JsonException jException)
                {
                    return new List<DealModel>();
                }
                catch (Exception e)
                {
                    return new List<DealModel>();
                }
            }
        }
    }
}
