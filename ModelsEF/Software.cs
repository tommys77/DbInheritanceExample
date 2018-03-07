using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEF
{
    public class Software : Item
    {
        public int YearOfRelease { get; set; }
        public Category Category { get; set; }
        public Review Review { get; set; }
    }

}
