using System;
using System.Collections.Generic;
using System.Text;

namespace Mealbox
{
    class Customer : Person
    {
        private string creditcardnumber;
        private string subscriptiontype;

        public string CreditCardNumber
        {
            get { return creditcardnumber; }
            set { creditcardnumber = value; }
        }
        public string SubscriptionType
        {
            get { return subscriptiontype; }
            set { subscriptiontype = value; }
        }


    }
}
