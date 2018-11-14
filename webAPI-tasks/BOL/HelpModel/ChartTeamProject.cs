using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.HelpModel
{
  public  class ChartTeamProject
    {
        public int IdProject { get; set; }
        public string  NameProject { get; set; }
        public int IdWorker { get; set; }
        public string NameWorker { get; set; }

        public decimal sumHourDoing { get; set; }

        public decimal SumHourNeedDoing { get; set; }
    }
}
