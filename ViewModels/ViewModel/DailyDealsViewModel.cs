using System;
using System.Windows;
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
        public ObservableCollection<DealModel> DealsList { get; set; }
        public DailyDealsViewModel()
        {
            DealsList = new ObservableCollection<DealModel>();
        }        
    }
}
