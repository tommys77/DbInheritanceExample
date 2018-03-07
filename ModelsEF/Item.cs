using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelsEF
{
    public class Item
    {
        [Key]
        [Column(Order = 1)]
        public int ItemId { get; set; }
        public string ItemName { get; set; }

        [ForeignKey("OwnerRefId")]
        public Owner Owner { get; set; }
        public int OwnerRefId { get; set; }
        
    }
}
