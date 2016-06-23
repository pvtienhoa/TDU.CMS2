using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DevExpress.XtraPrinting.Native;

namespace TDU.CMS2.DataModels
{
    public partial class User
    {
        [Required,Display(AutoGenerateField = true)]
        public long ID { get; set; }

        [Required,StringLength(50)]
        [Display(Name = "User Name")]
        public string UserName { get; set; }

        [Required,StringLength(100)]
        [Display(Name = "Employee name")]
        public string EmployeeName { get; set; }

        [Required,StringLength(10,MinimumLength = 4)]
        [Display(Name = "Teller ID")]public string TellerID { get; set; }
        [Required]
        public long DeptID { get; set; }
        [ForeignKey("DeptID")]
        public virtual Department Department { get; set; }

        public override string ToString()
        {
            return UserName + " (" + TellerID + ")";
        }
    }
}
