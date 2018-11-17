using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace HH_client_manager.Models.Database
{
    public class Account
    {
        [DisplayName("Account Username")]
        public string username { get; set; }

        [DisplayName("User First Name")]
        public string first_name { get; set; }

        [DisplayName("User Last Name")]
        public string last_name { get; set; }

        [DisplayName("Account Password")]
        public string password { get; set; }

        [DisplayName("Account Email Address")]
        public string email { get; set; }

        [DisplayName("Account Role Type")]
        public string role_type { get; set; }

        [DisplayName("Department Name")]
        public string department_name { get; set; }

        [DisplayName("Account Status")]
        public string status { get; set; }

    }
}
