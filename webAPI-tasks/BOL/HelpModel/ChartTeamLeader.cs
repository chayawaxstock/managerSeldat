using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.HelpModel
{
   public class ChartTeamLeader
    {
        public int IdWorker { get; set; }
        public string nameWorker { get; set; }
        public List<ChartTeamProject> ProjectsWorker { get; set; }
    }
}
