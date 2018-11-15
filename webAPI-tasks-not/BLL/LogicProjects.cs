using _00_DAL;
using BOL;
using BOL.Convertors;
using BOL.HelpModel;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace BLL
{
    public class LogicProjects
    {

        public static List<Project> GetAllProjects()
        {
            string query = $"SELECT p.*,u.* FROM managertasks.project p join user u on u.id=p.managerId";

            Func<MySqlDataReader, List<Project>> func = (reader) =>
            {
                List<Project> projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(ConvertProject.convertDBtoProjectsWithManager(reader));
                }
                return projects;
            };

            return DBAccess.RunReader(query, func);
        }


        public static Project GetProjectDetails(string projectName)
        {
            string query = $"SELECT * FROM managertasks.project WHERE name='{projectName}'";
            Func<MySqlDataReader, List<Project>> func = (reader) =>
            {
                List<Project> projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(new Project
                    {
                        ProjectId = reader.GetInt32(0),
                        ProjectName = reader.GetString(2),
                        CustomerName = reader.GetString(6),
                        numHourForProject = reader.GetDecimal(1),
                        DateBegin = reader.GetDateTime(3),
                        DateEnd = reader.GetDateTime(4),
                        IsFinish = reader.GetBoolean(5),
                        IdManager = reader.GetInt32(7)
                    });
                }
                return projects;
            };
            List<Project> list = DBAccess.RunReader(query, func);
            return(list!=null&&list.Count>0? list[0] : null);

        }


        public static Project GetProjectDetails(int projectId)
        {
            string query = $"SELECT * FROM managetasks.project WHERE projectId={projectId}";
            Func<MySqlDataReader, List<Project>> func = (reader) =>
            {
                List<Project> projects = new List<Project>();
                while (reader.Read())
                {
                    projects.Add(ConvertProject.convertDBtoProjects(reader));
                }
                return projects;
            };

            return (DBAccess.RunReader(query, func).Count() != 0 ? DBAccess.RunReader(query, func)[0] : null);

        }

        


        public static bool RemoveProject(string projectName)
        {
          //  int projectId = GetProjectDetails(projectName).Id;
          //  string query = $"DELETE FROM managetasks.projectworker WHERE projectid={projectId}";
          //if(DBAccess.RunNonQuery(query)!=1)
          //      return false;di
          //  query = $"DELETE FROM managetasks.projectworker WHERE projectid={projectId}";
          //  if (DBAccess.RunNonQuery(query) != 1)
          //      return false;
           string query = $"DELETE FROM managetasks.hourfordepartment WHERE Name={projectName}";
            return DBAccess.RunNonQuery(query) == 1;
        }



        public static bool UpdateProject(Project project)
        {
            string query = $"UPDATE managetasks.project SET numHour='{project.numHourForProject}',name='{project.ProjectName}',dateBegin={project.DateBegin} ,dateEnd={project.DateEnd} ,isFinish='{project.IsFinish}',customerName='{project.CustomerName}'  WHERE id={project.ProjectId} ";
            return DBAccess.RunNonQuery(query) == 1;
        }
        public static bool AddWorkerToProject(int projectId,List<UserWithoutPassword> workers)
        {
           
            foreach (var item in workers)
            {
                  string query = $"INSERT INTO `managertasks`.`projectworker`(`projectId`,`id`)VALUES({ projectId},{ item.UserId})";
                if (DBAccess.RunNonQuery(query)==null)
                    return false;
            }
            return true;
        }
        

        public static bool AddProject(Project project)
        {
            //TODO:איזה דפרטמנט
            string dateBegin = project.DateBegin.ToString("yyyy-MM-dd");
            string dateEnd = project.DateEnd.ToString("yyyy-MM-dd");
            int IsFinish= project.IsFinish ? 1 : 0;

            string query = $"INSERT INTO `managertasks`.`project`(`numHour`,`name`,`dateBegin`,`dateEnd`,`isFinish`,`customerName`,`managerId`) VALUES({project.numHourForProject},'{project.ProjectName}','{dateBegin}','{dateEnd}',{IsFinish},'{project.CustomerName}',{project.IdManager}); ";

            if (DBAccess.RunNonQuery(query) != null && DBAccess.RunStore("addProject", new List<string>() { project.IdManager.ToString() }, new List<string>() { "id" }) != null)
            {

                foreach (var item in project.HoursForDepartment)
                {
                    query = $"SET @EE=0;SELECT MAX(projectId) FROM project INTO @EE; INSERT INTO `managertasks`.`hourfordepartment`(`projectId`,`departmentId`,`sumHours`)VALUES(@EE,{item.DepartmentId},{item.SumHours});";
                    DBAccess.RunNonQuery(query);

                }
                return true;
            }
            else return false;

        }
        public static List<ReportWorker> CreateReports2(string viewName)
        {
            Func<MySqlDataReader, List<ReportWorker>> func = (reader) =>
            {
                List<ReportWorker> reportWorker = new List<ReportWorker>();
                while (reader.Read())
                {
                    reportWorker.Add(ConvertReport.ConvertDBtoReportWorker(reader));
                }
                return reportWorker;
            };

            return (DBAccess.RunReader(func, "report", new List<string>() { viewName }, new List<string>() { "viewName" }));
        }

        public static List<ReportProject> CreateReports1(string viewName)
        {
            Func<MySqlDataReader, List<ReportProject>> func = (reader) =>
            {
                List<ReportProject> reportProject = new List<ReportProject>();
                while (reader.Read())
                {
                    reportProject.Add(ConvertReport.ConvertDBtoReport(reader));
                }
                return reportProject;
            };

            return (DBAccess.RunReader(func, "report", new List<string>() { viewName }, new List<string>() { "viewName" }));
        }

        public static List<ReportProject> CreateReports(List<string> param)
        {

            Func<MySqlDataReader, List<ReportProject>> func = (reader) =>
            {
                List<ReportProject> reportProject = new List<ReportProject>();
                while (reader.Read())
                {
                    reportProject.Add(ConvertReport.ConvertDBtoReport(reader));
                }
                return reportProject;
            };

            return (DBAccess.RunReader(func, "CreateReport", new List<string>() { param[0] }, new List<string>() { param[1] }));

        }


        public static void sendEmailDateProjectEnd(object sender, ElapsedEventArgs e)
        {

            Func<MySqlDataReader, List<SendEmailEndProject>> func = (reader) =>
            {
                List<SendEmailEndProject> workerSendEmail = new List<SendEmailEndProject>();
                while (reader.Read())
                {
                    workerSendEmail.Add(ConvertSendEmail.convertDBtoProjects(reader));
                }
                return workerSendEmail;
            };
            List<SendEmailEndProject> workerNotFinish = DBAccess.RunReader(func, "SendEmailEndProject", new List<string>(), new List<string>());
            foreach (var item in workerNotFinish)
            {
                string message = $"Hi {item.UserName}<br/> the project {item.nameProject} the deadline tommorow You did {item.HourDo} from {item.hoursForProject}, You stay to do {item.stayToDo} hours ";
                LogicManager.SendEmail(item.EmailManager, item.EmailUser, "end dead line", message);
            }
            var d = workerNotFinish.GroupBy(p => p.EmailManager);
            foreach (var item in d)
            {
                string message = "";
                item.ToList().ForEach(user =>
                {
                    message += user.UserName + " ";
                });
                LogicManager.SendEmail("c0556777462@gmail.com", item.Key, "end dead line", message);
            }

        }


        public static async Task DeadLineEmail()
        {
            // Set up a timer that triggers every day.
            System.Timers.Timer timer = new System.Timers.Timer();
            timer.Interval = 60000;

            timer.Elapsed += new ElapsedEventHandler(sendEmailDateProjectEnd);

            string time = ConfigurationManager.AppSettings["deadLineEmailHour"];
            int hour = int.Parse(time.Split(':')[0]);
            int minute = int.Parse(time.Split(':')[1]);

            DateTime currentDateTime = DateTime.Now;
            DateTime dateTimeToStart = currentDateTime.Date + new TimeSpan(hour, minute, 0);
            if (dateTimeToStart < currentDateTime)
                dateTimeToStart = dateTimeToStart.AddDays(1);
            TimeSpan timeout = dateTimeToStart - currentDateTime;
            Thread.Sleep(timeout);
            timer.Start();
        }


        public static List<ReportWorker> CreateReports2(string viewName)
        {
            Func<MySqlDataReader, List<ReportWorker>> func = (reader) =>
            {
                List<ReportWorker> reportWorker = new List<ReportWorker>();
                while (reader.Read())
                {
                    reportWorker.Add(ConvertReport.ConvertDBtoReportWorker(reader));
                }
                return reportWorker;
            };

            return (DBAccess.RunReader(func, "report", new List<string>() { viewName }, new List<string>() { "viewName" }));
        }


        public static List<ReportProject> CreateReports1(string viewName)
        {
            Func<MySqlDataReader, List<ReportProject>> func = (reader) =>
            {
                List<ReportProject> reportProject = new List<ReportProject>();
                while (reader.Read())
                {
                    reportProject.Add(ConvertReport.ConvertDBtoReport(reader));
                }
                return reportProject;
            };

            return (DBAccess.RunReader(func, "report", new List<string>() { viewName }, new List<string>() {  "viewName" }));
        }
        

        public static List<ReportProject> CreateReports(List<string> param)
        {
            
            Func<MySqlDataReader, List<ReportProject>> func = (reader) =>
            {
                List<ReportProject> reportProject = new List<ReportProject>();
                while (reader.Read())
                {
                    reportProject.Add(ConvertReport.ConvertDBtoReport(reader));
                }
                return reportProject;
            };

            return (DBAccess.RunReader( func,"CreateReport", new List<string>() { param[0] },new List<string>() { param[1] }));
             
        }




    }
}
