using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TDU.CMS2.DataModels
{
    public class CardType
    {
        [Key,Display(AutoGenerateField = true)]
        public long ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Bin { get; set; }
    }
}
