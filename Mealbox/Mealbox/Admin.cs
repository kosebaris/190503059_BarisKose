using System;
using System.Collections.Generic;
using System.Text;

namespace Mealbox
{
    class Admin
    {

        private string adminId;
        private string title;

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


    }
}
