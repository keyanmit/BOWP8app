using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels.Model;
using Newtonsoft.Json;

namespace ViewModels.ViewModel
{
    public class DailyDealsViewModel
    {
        public ObservableCollection<DealModel> DealsList {get; set;}
        public DailyDealsViewModel()
        {
            DealsList = new ObservableCollection<DealModel>() { 
                new DealModel(){
                    DealId="1",
                    DealInfo="matter",
                    DealTitle = " Buy1 get 1 free",
                    TransactionUrl = "google.com?q=keyan"
                },
                new DealModel(){
                    DealId="2",
                    DealInfo="mango",
                    DealTitle = " Buy1 get 50% off",
                    TransactionUrl = "google.com?q=karthi"
                }
            };
        }
    }
}
