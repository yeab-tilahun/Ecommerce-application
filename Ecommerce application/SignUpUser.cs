﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce_application
{
    class SignUpUser
    {
        public string email;
        public string firstName;
        public string fatherName;
        public string userName;
        public string password;
        public string role;
        public string phone;
        public DateTime bithday;
        public SignUpUser(string fname, string lname, DateTime bday, string pnum, string email, string uname, string pass, string role)
        {
            this.email = email;
            this.firstName = fname;
            this.fatherName = lname;
            this.userName = uname;
            this.password = pass;
            this.role = role;
            this.phone = pnum;
            this.bithday = bday;
        }
        public void signUp()
        {
            //object for the third layer
        }
    }
}