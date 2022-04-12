using System;
using System.Collections.Generic;
using System.Text;

namespace Mealbox
{
    class Employee : Person
    {

        private string employeeId;
        private string title;

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


    }
}
