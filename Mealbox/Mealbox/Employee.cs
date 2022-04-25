using System;
using System.Collections.Generic;
using System.Text;

namespace Mealbox
{
    class Employee : Person
    {

        private string employeeId;
        private string title;
        private string pass;

        public string EmployeeId
        {
            get { return employeeId; }
            set { employeeId = value; }
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
