using System;
using System.Collections.Generic;
using System.Text;

namespace Mealbox
{
    class Person
    {

        private string firstName;
        private string lastName;
        private string phoneNumber;
        private string id;
        private string email;

        public string FirstName
        {
            get { return firstName;}
            set { firstName = value;}
        }

        public string LastName
        {
            get { return lastName;}
            set { lastName = value;}
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        public string EMail
        {
            get { return email; }
            set { email = value; }
        }



    }
}
