﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Constants
{
    public class DealServerSettings
    {
        static DealServerSettings()
        {
            BingDomain = "http://bing.com";
            DealsDomain = "http://deals.msftoffers.com";
            ResultCount = 3;
            Country_Region = "IN";
            Ranking = "distance";
            ClientId = "bofrs_browse";
            BingOffersDealDetailsPath = "/offers/dailydeals/details/";
            BingOffersNearbyDeals = "{0}/api/lomoDeals/GetNearbyDeals?coord={1},{2}&count={3}&radius={4}&client={5}&refinements={6}";
            QueryRadius = 5000;
        }
        public static string BingDomain { get; set; }
        public static string DealsDomain { get; set; }
        public static int QueryRadius { get; set; }
        public static int ResultCount { get; set; }
        public static string Country_Region { get; private set; }
        public static string Ranking { get; private set; }
        public static string ClientId { get; private set; }
        public static string BingOffersDealDetailsPath { get; private set; }
        public static string BingOffersNearbyDeals { get; private set; }
    }
}
