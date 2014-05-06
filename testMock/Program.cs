using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Facade.DAL;
using ViewModels.Model;
using ViewModels.ViewModel;
using System.Threading.Tasks;

namespace testMock
{
    class Program
    {
        static void Main(string[] args)
        {
            var refinement = new QueryRefineModel()
            {
                Ranking = "sort",
                Resultsperbiz = 1,
            };

            Task.Run(() =>
            {
                var dealList = DealServer.GetNearByDeals(new DealServerQueryModel()
                {
                    Count = 5,
                    Latitude = 12.930137,
                    Longitude = 77.587733,
                    Refinement = refinement
                });
            }).Wait();

            //Console.ReadLine();
        }
    }
}
