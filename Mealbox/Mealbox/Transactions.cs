using System;
using System.Collections.Generic;
using System.Text;

namespace Mealbox
{
    class Transactions
    {
        private string id;
        private string cost;
        private string customerId;
        private string deliveryId;
        private string paymentId;


        public string id
        {
            get { return id; }
            set { id = value; }
        }

        public string Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public string CustomerId
        {
            get { return customerId; }
            set { customerId = value; }
        }
        public string DeliveryId
        {
            get { return deliveryId; }
            set { deliveryId = value; }
        }
        public string PaymentId
        {
            get { return paymentId; }
            set { paymentId = value; }
        }



    }
}
