
using _00_DAL;
using BOL;
using BOL.Convertors;
using BOL.HelpModel;
using BOL.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection;

namespace BLL
{
    public class LogicManager
    {

        public static List<UserWithoutPassword> GetAllUsers()
        {
            string query = $"SELECT * FROM managertasks.user JOIN managertasks.department ON user.departmentUserId=department.id ;";

            Func<MySqlDataReader, List<UserWithoutPassword>> func = (reader) =>
            {
                List<UserWithoutPassword> users = new List<UserWithoutPassword>();
                while (reader.Read())
                {
                    users.Add(ConvertorUser.convertDBtoUser(reader));
                }
                return users;
            };

            return DBAccess.RunReader(query, func);
        }


        public static List<User> ConfirmPassword()
        {
            string query = $"SELECT * FROM managertasks.user JOIN managertasks.department ON user.departmentUserId=department.id ;";

            Func<MySqlDataReader, List<User>> func = (reader) =>
            {
                List<User> users = new List<User>();
                while (reader.Read())
                {
                    users.Add(ConvertorUser.convertDBtoConfirm(reader));
                }
                return users;
            };

            return DBAccess.RunReader(query, func);
        }


        public static List<DepartmentUser> getAllDepartments()
        {
            string query = $"SELECT * FROM managertasks.department  ";

            Func<MySqlDataReader, List<DepartmentUser>> func = (reader) =>
            {
                List<DepartmentUser> departments = new List<DepartmentUser>();
                while (reader.Read())
                {
                    departments.Add(ConvertDepartment.convertDBtoDepartment(reader));
                }
                return departments;
            };

            return DBAccess.RunReader(query, func);
        }

       

        public static List<UserWithoutPassword> getUserByDepartment(string departmentName)
        {
            string query = $"SELECT * FROM managertasks.user JOIN managertasks.department ON user.departmentUserId=department.id WHERE Department='{departmentName}'";

            Func<MySqlDataReader, List<UserWithoutPassword>> func = (reader) =>
            {
                List<UserWithoutPassword> users = new List<UserWithoutPassword>();
                while (reader.Read())
                {
                    users.Add(ConvertorUser.convertDBtoUser(reader));
                }
                return users;
            };

            return DBAccess.RunReader(query, func);
        }

        

        public static List<SumHoursDoneUser> getSumHoursDoneForUsers(int teamleaderId)
        {
            string query = $"select sum(sumHours),u.userName from presentday p join user u on u.id= p.id where u.managerId ={teamleaderId} group by u.id";

            Func<MySqlDataReader, List<SumHoursDoneUser>> func = (reader) =>
            {
                List<SumHoursDoneUser> users = new List<SumHoursDoneUser>();
                while (reader.Read())
                {
                    users.Add(BOL.Convertors.ConvertSumHoursUser.convertDBtoSumHoursUser(reader));
                }
                return users;
            };

            return DBAccess.RunReader(query, func);
        }

        public static List<SumHoursUserDoneByMonth> getSumHoursUserDoneByMonth(int id)
        {
            string query = $"SELECT p.name,sum(sumHours),month(timeBegin) FROM managertasks.presentday pr join project p on pr.projectId=p.projectId where id={id} and year(timeBegin)=YEAR(CURDATE())  group by month(timeBegin),pr.projectId,p.name order by month(timeBegin)"; 

            Func<MySqlDataReader, List<SumHoursUserDoneByMonth>> func = (reader) =>
            {
                List<SumHoursUserDoneByMonth> dataList = new List<SumHoursUserDoneByMonth>();
                while (reader.Read())
                {
                    dataList.Add(ConvertSumHoursUser.convertDBtoSumHoursUserDoneByMonth(reader));
                }
                return dataList;
            };

            return DBAccess.RunReader(query, func);
        }

        public static List<SumHoursDoneUser> getHoursForUserProjects(int userId)
        {
            string query = $"select * from sumHoursForUserProject where id={userId}";

            Func<MySqlDataReader, List<SumHoursDoneUser>> func = (reader) =>
            {
                List<SumHoursDoneUser> users = new List<SumHoursDoneUser>();
                while (reader.Read())
                {
                    users.Add(BOL.Convertors.ConvertSumHoursUser.convertDBtoSumHoursUser(reader));
                }
                return users;
            };

            return DBAccess.RunReader(query, func);
        }


        public static List<ProjectWorker> getHoursAndProjectForUser(int userId)
        {
            string query = $"SELECT pw.projectId,pw.id,pw.hoursForProject,p.name,u.userName FROM   project p JOIN projectworker pw ON  p.projectId =pw.projectId JOIN user u ON pw.id =u.id WHERE pw.id={userId}";

            Func<MySqlDataReader, List<ProjectWorker>> func = (reader) =>
            {
                List<ProjectWorker> users = new List<ProjectWorker>();
                while (reader.Read())
                {
                    users.Add(ConvertProjectWorker.convertDBtoProjectWorkersWithProjectAndUser1(reader));
                }
                return users;
            };

            return DBAccess.RunReader(query, func);
        }

        public static List<UserWithoutPassword> getUsersOfTeamLeader(int teamleaderId)
        {
            string query = $"SELECT * FROM managertasks.user WHERE managerId={teamleaderId}";

            Func<MySqlDataReader, List<UserWithoutPassword>> func = (reader) =>
            {
                List<UserWithoutPassword> users = new List<UserWithoutPassword>();
                while (reader.Read())
                {
                    users.Add(ConvertorUser.convertDBtoUser1(reader));
                }
                return users;
            };

            return DBAccess.RunReader(query, func);
        }

        public static List<SumHoursDoneUser> getWorkerHourDoProjects(int teamleaderId,int idProject)
        {
            string query = $"select sum(pd.sumHours),u.userName  from user u join projectworker pw on pw.id = u.id left join presentday pd on pd.id = u.id where u.managerId = {teamleaderId} and pw.projectId = {idProject} and pd.projectId = {idProject} group by pw.projectId ,pw.id ";

            Func<MySqlDataReader, List<SumHoursDoneUser>> func = (reader) =>
            {
                List<SumHoursDoneUser> sumHoursDoneUser = new List<SumHoursDoneUser>();
                while (reader.Read())
                {
                    sumHoursDoneUser.Add(ConvertSumHoursUser.convertDBtoSumHoursUserProject(reader));
                }
                return sumHoursDoneUser;
            };

            return DBAccess.RunReader(query, func);
        }

        //public static List<ChartTeamLeader> GetWorkerTeamLeaderWithHourDo(int teamleaderId)
        //{

        //    List<UserWithoutPassword> worker = getUsersOfTeamLeader(teamleaderId);

        //    string query = $"select u.id, u.userName,p.projectId,p.name,pw.hoursForProject,sum(pd.sumHours) from project p join projectworker pw on pw.projectId = p.projectId join user u on u.id = pw.id left join presentday pd on pd.id = pw.id  where u.managerId = {teamleaderId}  group by pw.projectId ,pw.id";
        //    Func<MySqlDataReader, List<ChartTeamProject>> func = (reader) =>
        //    {
        //        List<ChartTeamProject> chartTeamProject = new List<ChartTeamProject>();
        //        while (reader.Read())
        //        {
        //            chartTeamProject.Add(ConvertProjectWorker.convertChartTeamProject(reader));
        //        }

        //        return chartTeamProject;
        //    };

        //    var projectWorker = DBAccess.RunReader(query, func);
        //    var projectWorkerChart=  projectWorker.GroupBy(p => p.IdWorker);
        //    return new List<ChartTeamLeader>();

        //}
        //כמה שעות עשה כל עובד לפרויקט מסוים
       public static List<SumHoursDoneUser> getUserProjectTeamHourDo(int idTeamLeader,int idProject)
        {
            string query = $"select sum(pd.sumHours),u.userName from user u join projectworker pwon pw.id = u.id join presentday pd on pd.id = u.id where u.managerId = {idTeamLeader} and pw.projectId = {idProject} and pd.projectId = 1 group by pw.projectId ,pw.id";
            List<SumHoursDoneUser> projectWorker = new List<SumHoursDoneUser>();
            Func<MySqlDataReader, List<SumHoursDoneUser>> func = (reader) =>
            {
                List<SumHoursDoneUser> projectWorkers = new List<SumHoursDoneUser>();
                while (reader.Read())
                {
                    projectWorkers.Add(ConvertSumHoursUser.convertDBtoSumHoursUserProject(reader));
                }
                return projectWorkers;
            };

          return  projectWorker = DBAccess.RunReader(query, func);
        }

        public static List<ProjectWorker> getUsersBelongProjects(int projectId)
        {
            string query = $"SELECT * FROM   project p JOIN projectworker pw ON  p.projectId =pw.projectId JOIN user u ON pw.id =u.id WHERE pw.projectId={projectId}";
            List<ProjectWorker> projectWorker = new List<ProjectWorker>();
            Func<MySqlDataReader, List<ProjectWorker>> func = (reader) =>
            {
                List<ProjectWorker> projectWorkers = new List<ProjectWorker>();
                while (reader.Read())
                {
                    projectWorkers.Add(ConvertProjectWorker.convertDBtoProjectWorkersWithProjectAndUser(reader));
                }
                return projectWorkers;
            };

            projectWorker = DBAccess.RunReader(query, func);

            foreach (var item in projectWorker)
            {
                query = $" SELECT sum(sumHours) FROM managertasks.presentday where id ={item.UserId} and projectId ={item.ProjectId}";
                string result = DBAccess.RunScalar(query).ToString();
                item.sumHoursDone = result != string.Empty ? decimal.Parse(result.ToString()) : 0;
            }
            return projectWorker;

        }
        public static List<UserWithoutPassword> getWorkers()
        {
            //TODO:לקבל משתמשים שלא נמצאים בפרויקט
            string query = $"SELECT * FROM managertasks.user JOIN managertasks.department ON user.departmentUserId=department.id WHERE Department IN ('UX','UI','development','QA')";

            Func<MySqlDataReader, List<UserWithoutPassword>> func = (reader) =>
            {
                List<UserWithoutPassword> users = new List<UserWithoutPassword>();
                while (reader.Read())
                {
                    users.Add(ConvertorUser.convertDBtoUser(reader));
                }
                return users;
            };

            return DBAccess.RunReader(query, func);
        }




        public static List<Project> getProjectsManager(int id)
        {
            string query = $"SELECT * FROM managertasks.project WHERE managerId ={id}";

            Func<MySqlDataReader, List<Project>> func = (reader) =>
            {
                List<Project> projectsList = new List<Project>();
                while (reader.Read())
                {
                    projectsList.Add(ConvertProject.convertDBtoProjects(reader));
                }
                return projectsList;
            };

            return DBAccess.RunReader(query, func);
        }

        public static List<ProjectWorker> GetProjectsUser(int id)
        {
            string query = $"SELECT* FROM managertasks.projectworker pw join project p on  pw.projectId = p.projectId where pw.id ={id } ";

            Func<MySqlDataReader, List<ProjectWorker>> func = (reader) =>
            {
                List<ProjectWorker> projectsList = new List<ProjectWorker>();
                while (reader.Read())
                {
                    projectsList.Add(ConvertProjectWorker.convertDBtoProjectWorkersWithProject(reader));
                }
                return projectsList;
            };

            return DBAccess.RunReader(query, func);
        }


        public static UserWithoutPassword GetUserDetails(int id)
        {
            string query = $"SELECT * FROM managertasks.user JOIN managertasks.department ON user.departmentUserId=department.id WHERE user.id={id}";
            List<UserWithoutPassword> users = new List<UserWithoutPassword>();
            Func<MySqlDataReader, List<UserWithoutPassword>> func = (reader) =>
            {
                List<UserWithoutPassword> projectsWorker = new List<UserWithoutPassword>();
                while (reader.Read())
                {
                    projectsWorker.Add(ConvertorUser.convertDBtoUser(reader));
                }
                return projectsWorker;
            };
            List<UserWithoutPassword> users1 = DBAccess.RunReader(query, func);
            return users1 != null && users1.Count > 0 ? users1[0] as UserWithoutPassword : null;
        }

        public static UserWithoutPassword GetUserDetailsByPassword(LoginUser user)
        {
            //TODO:לעשות פונקציה שבודקת תווים מיוחדים עי סטור ופונקציה
            string query = $"SELECT * FROM managertasks.user JOIN managertasks.department ON user.departmentUserId=department.id  WHERE password='{user.Password}' AND userName='{user.UserName}'";

            Func<MySqlDataReader, List<UserWithoutPassword>> func = (reader) =>
            {
                List<UserWithoutPassword> users = new List<UserWithoutPassword>();
                while (reader.Read())
                {
                    users.Add(ConvertorUser.convertDBtoUser(reader));
                }
                return users;
            };

            List<UserWithoutPassword> usersLogin = DBAccess.RunReader(query, func);
            if (usersLogin != null && usersLogin.Count > 0)
            {
                query = $"    UPDATE `managertasks`.`user`SET`userComputer` = '{user.Ip}' WHERE password = '{user.Password}' ";
                //return DBAccess.RunNonQuery(query) == 1;
                return usersLogin[0];
            }
            return null;

        }

        public static bool RemoveUser(int id)
        {
            string query = $"DELETE FROM managertasks.user WHERE id={id}";
            return DBAccess.RunNonQuery(query) != null;
        }
        //-------------------------------------------

        public static bool UpdateUser(UserWithoutPassword user)
        {
            string query;
            query = user.ManagerId == 0 || user.ManagerId == null ? $"UPDATE managertasks.user SET userName='{user.UserName}',departmentUserId={user.DepartmentId} ,email='{user.Email}',userComputer='{user.UserComputer}',numHourWork={user.NumHoursWork}  WHERE id={user.UserId} " : $"UPDATE managertasks.user SET userName='{user.UserName}',departmentUserId={user.DepartmentId} ,managerId={user.ManagerId} ,email='{user.Email}',userComputer='{user.UserComputer}',numHourWork={user.NumHoursWork}  WHERE id={user.UserId} ";

            return DBAccess.RunNonQuery(query) == 1;
        }


        public static bool AddUser(User user)
        {
            string query;
            //TODO:איזה דפרטמנט
            if (user.ManagerId == 0 || user.ManagerId == null)
                query = $"INSERT INTO `managertasks`.`user`(`userName`,`userComputer`,`password`,`departmentUserId`,`email`,`numHourWork`) VALUES('{user.UserName}','{user.UserComputer}','{user.Password}',{user.DepartmentId},'{user.Email}',{user.NumHoursWork}); ";
            else query = $"INSERT INTO `managertasks`.`user`(`userName`,`userComputer`,`password`,`departmentUserId`,`email`,`numHourWork`,`managerId`) VALUES('{user.UserName}','{user.UserComputer}','{user.Password}',{user.DepartmentId},'{user.Email}',{user.NumHoursWork},{user.ManagerId}); ";

            return DBAccess.RunNonQuery(query) == 1;
        }

        public static UserWithoutPassword GetUserDetailsComputerUser(string computerUser)
        {
            string query = $" SELECT* FROM managetasks.user JOIN managetasks.department ON user.departmentUserId = department.id  WHERE userComputer = '{computerUser}'";

            Func<MySqlDataReader, List<UserWithoutPassword>> func = (reader) =>
            {
                List<UserWithoutPassword> users = new List<UserWithoutPassword>();
                while (reader.Read())
                {
                    users.Add(ConvertorUser.convertDBtoUser(reader));

                }
                return users;
            };

            List<UserWithoutPassword> usersLogin = DBAccess.RunReader(query, func);
            if (usersLogin != null && usersLogin.Count > 0)
            {
                return usersLogin[0];
            }
            return null;
        }


        public static UserWithoutPassword GetUserManager(int idUser)
        {
            string query = $" select uu.* from user u join user uu on u.managerId=uu.id where u.id={idUser}";

            Func<MySqlDataReader, List<UserWithoutPassword>> func = (reader) =>
            {
                List<UserWithoutPassword> users = new List<UserWithoutPassword>();
                while (reader.Read())
                {
                    users.Add(ConvertorUser.convertDBtoUser1(reader));
                }
                return users;
            };

            List<UserWithoutPassword> manager = DBAccess.RunReader(query, func);
            if (manager != null && manager.Count > 0)
            {

                return manager[0];
            }
            return null;
        }


        //public int Authenticate(string userName, string password)
        //{
        //    var user = GetUserDetailsByPassword(password,userName);
        //    if (user != null )
        //    {
        //        return user.UserId;
        //    }
        //    return 0;
        //}



        public static bool sendMessageToManagers(int idUser, string message)
        {
            UserWithoutPassword manager = GetUserManager(idUser);
            UserWithoutPassword user = GetUserDetails(idUser);
            if (manager == null)
                return false;
            return SendEmail(user.Email, manager.Email, "עזרה", message);
        }


        public static bool SendEmail(string emailFrom, string emailTo, string sub, string message)
        {
            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Host = "smtp.gmail.com";
            client.Port = 587;
            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("c0556777462@gmail.com", "207322868");
            client.UseDefaultCredentials = false;
            client.Credentials = credentials;
            MailMessage msg = new MailMessage();
            msg.From = new MailAddress(emailFrom);
            msg.To.Add(new MailAddress(emailTo));
            msg.Subject = sub;
            msg.IsBodyHtml = true;
            msg.Body = string.Format($"<html><head>הודעה שנשלחה</head><body><p>{message}</br></p></body>");
            try
            {
                client.Send(msg);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }


    }
}

