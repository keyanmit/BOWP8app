using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Constants;
using ViewModels.Model;

namespace Facade.Factory
{
    public class ClientUriBuilder
    {
        private static string AddClientIdToUri(string url)
        {

            if (url.IndexOf('?') == -1)
                url += '?';
            if (url[url.Length - 1] != '?')
                url += "&";
            url += ("bor=" + DealServerSettings.ClientId);
            return url;
        }

        public static string FixRedirectUrl(string url, string dealId)
        {
            if (!url.Contains("/offers/"))
            {
                /* expects the seo url to be of form "/offers/<seo>"
                 * "/offers/" will be a minimum requirement for a potentially valid seo url
                 * if in-valid use deal id to redirect the user
                 * if a in-valid url escapes this check, user will be redirected to bing offers atleast
                 */
                url = DealServerSettings.BingOffersDealDetailsPath + dealId;
            }
            return url;
        }

        public static Uri BuildUri(string sitePath)
        {
            return new Uri(AddClientIdToUri(DealServerSettings.BingDomain + sitePath));
        }

        public static Uri GetDealServerUri(DealServerQueryModel model)
        {
            var UriString = String.Format(DealServerSettings.BingOffersNearbyDeals, DealServerSettings.DealsDomain,
                model.Latitude,
                model.Longitude, model.Count, DealServerSettings.QueryRadius, DealServerSettings.ClientId, model.Refinement.ConstructRefinementParam());
            return new Uri(UriString);
        }
    }
}
