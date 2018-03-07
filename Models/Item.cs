using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Item
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public Owner Owner { get; set; }
    }
}
