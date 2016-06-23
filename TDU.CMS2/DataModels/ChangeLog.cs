using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TDU.CMS2.DataModels
{
    public class ChangeLog
    {
        [Key,Display(AutoGenerateField = true)]
        public int ID { get; set; }
        public string EntityName { get; set; }
        public string PropertyName { get; set; }
        public string PrimaryKeyValue { get; set; }
        public string OldValue { get; set; }
        public string NewValue { get; set; }
        public DateTime DateChanged { get; set; }
        public string UserName { get; set; }
    }
}