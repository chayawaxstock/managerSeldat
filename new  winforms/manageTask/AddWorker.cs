using manageTask.Logic;
using manageTask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls;

namespace manageTask
{
    public partial class AddWorker : Telerik.WinControls.UI.RadForm
    {
        public AddWorker()
        {
            InitializeComponent();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {

            User worker = getWorker();
            if (ModelState.IsValid(worker))
            {
                radWaitingBar2.Show();
                radWaitingBar2.StartWaiting();

                //add worker to db
                if (TaskRequests.addWorker(worker))
                {
                    //secsess add worker
                    RadMessageBox.SetThemeName("MaterialTeal");
                    RadMessageBox.Show("succsess", "worker added", MessageBoxButtons.OK, RadMessageIcon.None, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    //fail to add worker
                    RadMessageBox.SetThemeName("MaterialTeal");
                    RadMessageBox.Show("error add project", "error", MessageBoxButtons.OK, RadMessageIcon.Error, MessageBoxDefaultButton.Button1);
                }
                
                radWaitingBar2.StopWaiting();
                radWaitingBar2.Hide();
            }
            else
            {
                //model invalid set error
                foreach (var item in ModelState.Results)
                {
                    errorProvider1.SetError(Controls["txt_" + item.MemberNames.ToList()[0]], item.ErrorMessage);
                }
            }
        }

        public User getWorker()
        {
            User worker = new User();
            worker.UserName = txt_UserName.Text;

            //convert password to sha256
            worker.Password = UserLogic.passwordToSHA(txt_Password.Text);
            worker.NumHoursWork = txt_NumHoursWork.Value;
            worker.Email = txt_Email.Text;
            worker.DepartmentId = (cmbx_department.SelectedItem as DepartmentUser).Id;

            if (cmbx_teamLeader.Items.Count != 0)
                worker.ManagerId = (cmbx_teamLeader.SelectedItem as User).UserId;
            else
                worker.ManagerId = 0;
            return worker;
        }

        private void AddWorker_Load(object sender, EventArgs e)
        {
            //get all departments

            List<DepartmentUser> departments = UserLogic.getAllDepartments();
            if (departments != null)
            {
                cmbx_department.DisplayMember = "Department";

                cmbx_department.Items.AddRange((departments.ToArray()));
               
            }

        }

        private void cmbx_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbx_teamLeader.Items.Clear();

            //choose to add develpment,QA,QX,UI
            if ((cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.DEVELOPMENT.ToString() || (cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.UI.ToString() || (cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.UX.ToString() || (cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.QA.ToString())
            {
                cmbx_teamLeader.Visible = true;
                lbl_team_leader.Visible = true;

                //get all the teamleaders
                List<User> teamLeaders = UserLogic.getUserByDepartment(GlobalProp.TeamLeaderNameDepartment);
                if (teamLeaders != null)
                {
                    cmbx_teamLeader.DisplayMember = "UserName";
                    cmbx_teamLeader.Items.AddRange(teamLeaders.ToArray());
                }

            }
            //choose to add teamLeader
            else if ((cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.TEAMLEADER.ToString())
            {
                cmbx_teamLeader.Visible = true;
                lbl_team_leader.Visible = true;

                //get all Managers
                List<User> managers = UserLogic.getUserByDepartment(GlobalProp.ManagerNameDepartment);
                cmbx_teamLeader.DisplayMember = "UserName";
                cmbx_teamLeader.Items.AddRange(managers.ToArray());

            }
            //choose add manager
            else if ((cmbx_department.SelectedItem as DepartmentUser).Department.ToUpper() == department.MANAGER.ToString())
            {
                cmbx_teamLeader.Visible = false;
                lbl_team_leader.Visible = false;
            }

        }
    }
}

