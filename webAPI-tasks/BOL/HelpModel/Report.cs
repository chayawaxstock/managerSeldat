using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.HelpModel
{
   public class ReportProject
    {
        public Project Project { get; set; }
        public string manager { get; set; }
        public int NumWorkers { get; set; }
   
        public decimal sumHourWork { get; set; }
        public int DaysStay { get; set; }
        public decimal presentDoing { get; set; }
        public decimal NumHourDoDaysWorker { get; set; }

    }
}
