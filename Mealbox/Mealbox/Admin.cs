using System;
using System.Collections.Generic;
using System.Text;

namespace Mealbox
{
    class Admin : Person
    {

        private string adminId;
        private string title;
        private string pass;

        public string EmployeeId
        {
            get { return adminId; }
            set { adminId = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }


    }
}
