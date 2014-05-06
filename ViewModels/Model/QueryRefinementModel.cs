using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels.Model
{
    public class QueryRefineModel
    {
        public string source { get; set; }
        public int TimeOut { get; set; }
        public int Offset { get; set; }
        public string Keyword { get; set; }
        public int Resultsperbiz { get; set; }
        public string Ranking { get; set; }

        public QueryRefineModel()
        {
            source = Keyword = string.Empty;
            TimeOut = Offset = 0;
            Resultsperbiz = 1;
        }

        public string ConstructRefinementParam()
        {
            string refinement = string.Empty;
            if (source != string.Empty)
                refinement += ";source:" + source;
            if (TimeOut != 0)
                refinement += (";timeout:" + TimeOut);
            if (Offset != 0)
                refinement += (";offset:" + Offset);
            if (Keyword != string.Empty)
                refinement += ";keyword:" + Keyword;
            if (Resultsperbiz != -1)
                refinement += (";resultsperbiz:" + Resultsperbiz);
            if (Ranking != string.Empty)
                refinement += ";ranking:" + Ranking;
            return refinement.Substring(refinement.IndexOf(';') + 1);
        }
    }
}
