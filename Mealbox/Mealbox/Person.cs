using System;
using System.Collections.Generic;
using System.Text;

namespace Mealbox
{
    class Person
    {
        
        protected string firstName;
        protected string lastName;
        protected string phoneNumber;
        protected string id;
        protected string email;

        /*public Person()
        {
        }

        public Person(string firstName, string lastName, string phoneNumber, string id, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.phoneNumber = phoneNumber;
            this.id = id;
            this.email = email;
            
            
        }*/


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
