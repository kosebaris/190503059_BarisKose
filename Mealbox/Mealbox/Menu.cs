using System;
using System.Collections.Generic;
using System.Text;

namespace Mealbox
{
    class Menu
    {
        private string id;
        private string menuType;
        private string menuNo;
        private string content;
        private string price;
        private string description;


        public string ID
        {
            get { return id; }
            set { id = value; }
        }

        public string MenuType
        {
            get { return menuType; }
            set { menuType = value; }
        }
        public string MenuNo
        {
            get { return menuNo; }
            set { menuNo = value; }
        }
        public string Content
        {
            get { return content; }
            set { content = value; }
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



    }
}
