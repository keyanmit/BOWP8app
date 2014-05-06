using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Facade.DAL;
using ViewModels.Model;
using ViewModels.ViewModel;
using System.Threading.Tasks;

namespace BOAppComponentTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async Task<bool> DealServerTest()
        {
            var refinement = new QueryRefineModel()
            {
                Ranking = "sort",
                Resultsperbiz = 1,
            };
            var dealList = await DealServer.GetNearByDeals(new DealServerQueryModel()
            {
                Count = 5,
                Latitude = 12.930137,
                Longitude = 77.587733,
                Refinement = refinement
            });

            Assert.IsTrue(dealList != null && dealList.Count > 0);
            return true;
        }

        [TestMethod]
        public void run()
        {
            var k = 100 / 2;
            Assert.Equals(k, 50);
        }
    }
}
