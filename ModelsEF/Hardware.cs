using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEF
{
    public class Hardware : Item
    {
        public string ProductionCompany { get; set; }
        public int YearOfOrigin { get; set; }
    }
}
