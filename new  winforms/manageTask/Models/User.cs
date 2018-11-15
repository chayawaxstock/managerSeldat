
using manageTask.Validations;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace manageTask.Models
{
  public class User
        {
            public User()
            {
                Projects = new List<Project>();
                PresentsDayUser = new List<PresentDay>();
                users = new List<User>();
            }

            public int UserId { get; set; }

            [Required(ErrorMessage = "name is required")]
            [RegularExpression("@ ^[a - zA - Z]",ErrorMessage ="name must  contain only letters")]
            [MinLength(2, ErrorMessage = "name must be more than 2 chars"), MaxLength(15, ErrorMessage = "name must be less than 15 chars")]
            public string UserName { get; set; }

            [Required(ErrorMessage = "password is required")]
            public string Password { get; set; }

            [Required(ErrorMessage = "email is required")]
            [EmailAddress(ErrorMessage ="email adress invalid")]
            public string Email { get; set; }
           
            public string UserComputer { get; set; } = "";
            
            [Range(2,12,ErrorMessage ="num hour between 2-12")]
            public decimal NumHoursWork { get; set; } = 9;

            public int? ManagerId { get; set; }
            public int DepartmentId { get; set; }

            public DepartmentUser DepartmentUser { get; set; }
            public List<Project> Projects { get; set; }
            public User Manager { get; set; }
            public List<PresentDay> PresentsDayUser { get; set; }

            public List<User> users { get; set; }

        }
    }



