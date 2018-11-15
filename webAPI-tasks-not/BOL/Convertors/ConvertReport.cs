using BOL.HelpModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL.Convertors
{
   public class ConvertReport
    {
        public static ReportProject ConvertDBtoReport(MySqlDataReader readerRow)
        {
            return new ReportProject()
            {
                Project = ConvertProject.convertDBtoProjects(readerRow),
                manager=readerRow.GetString(8),
                NumWorkers=readerRow.GetInt32(9),
                sumHourWork=readerRow.IsDBNull(10)?0:  readerRow.GetDecimal(10),
                DaysStay= readerRow.IsDBNull(11) ? 0 : readerRow.GetInt32(11),
                presentDoing= readerRow.IsDBNull(12) ? 0 : readerRow.GetDecimal(12),
                NumHourDoDaysWorker= readerRow.IsDBNull(13) ? 0 : readerRow.GetDecimal(13)
            };
        }

        public static ReportWorker ConvertDBtoReportWorker(MySqlDataReader readerRow)
        {
            return new ReportWorker()
            {
               
            };
        }

    }
}
