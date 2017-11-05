using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TreeContainer
{
    public class MyListBoxItem
    {
        public string name { get; set; }
        public string description { get; set; }
        public MyListBoxItem(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
    }
}
