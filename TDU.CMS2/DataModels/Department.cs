using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDU.CMS2.DataModels
{
    public enum DepartmentType{
        HeadOffice,
        MainDept,
        SubDept,
        Customer,
        NA
    }

    public class Department
    {
        [Key, Display(AutoGenerateField = true)]
        public long ID { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Department Name", ShortName = "Name")]
        public string Name { get; set; }

        [Required, StringLength(50)]
        [Display(Name = "Department Short Name", ShortName = "ShortName")]
        public string ShortName { get; set; }

        [Required]
        [DefaultValue(DepartmentType.SubDept)]
        [EnumDataType(typeof(DepartmentType))]
        [Display(Name = "Department Type", ShortName = "Type")]
        public DepartmentType Type { get; set; }

        [Required,StringLength(10)]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [StringLength(100)]
        [Display(Name = "Description")]
        public string Description { get; set; }
    }
}
