using System;
using System.Collections.Generic;
using System.Text;

namespace Mealbox
{
    class Product
    {
        private string id;
        private string name;
        private string price;
        private string description;
        private string imageURL;

        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Price
        {
            get { return price; }
            set { price = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public string ImageURL
        {
            get { return imageURL; }
            set { imageURL = value; }
        }



    }
}
