using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Model
{
    public class DealServerQueryModel
    {
        public QueryRefineModel Refinement { get; set; }
        public int Count { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
}
