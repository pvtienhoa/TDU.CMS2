using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDU.CMS2.DataModels
{
    public class CardInfo
    {
        [Key]
        public string CardNumber { get; set; }

        public long TypeID { get; set; }

        [ForeignKey("TypeID")]
        public virtual CardType Type { get; set; }

        public string AccountNumber { get; set; }

        public string CardHolder { get; set; }

        public virtual ICollection<CardRequest> Requests { get; set; }

    }
}
