using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeramecNetFlixProject.Business_Objects
{
    public class Member
    {
        public int Member_number { get; set; }
        public DateTime Joindate { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public string Member_status { get; set; }
        public string Login_name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public int Contact_method { get; set; }
        public int Subscription_id { get; set; }
        public string Photo { get; set; }
    }
}
