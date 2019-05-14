using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeramecNetFlixProject.Business_Objects
{
    class Member
    {
        public Member(int member_number, DateTime joindate, string firstname, string lastname, string address, 
            string city, string state, string zipcode, string phone, string member_status, string login_name, 
            string password, string email, int contact_method, int subscription_id, string photo)
        {
            Member_number = member_number;
            Joindate = joindate;
            Firstname = firstname;
            Lastname = lastname;
            Address = address;
            City = city;
            State = state;
            Zipcode = zipcode;
            Phone = phone;
            Member_status = member_status;
            Login_name = login_name;
            Password = password;
            Email = email;
            Contact_method = contact_method;
            Subscription_id = subscription_id;
            Photo = photo;
        }

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
