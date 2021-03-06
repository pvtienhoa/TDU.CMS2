﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDU.CMS2.DataModels
{
    public enum RequestType
    {
        Issue,
        ReIssue,
        PinReset,
        Lock,
        Destroy,
        Extend
    }

    public enum RequestState
    {
        Producing,       //Dang SX
        Received,       //Da nhan the tu TW
        Devided,       //Da chia the
        InDept,       //Da nhan the sau chia
        Taken,       //Da Giao Khach
        Activated,  //Da Kich Hoat
        Destroyed, //Da Huy
        Missing   //Da Mat
    }

    public class CardRequest
    {
        [Key, Display(AutoGenerateField = true)]
        public long ID { get; set; }

        [StringLength(30, MinimumLength = 4)]
        [Display(Name = "Card Number", ShortName = "CardNo")]
        public string CardNumber { get; set; }

        [StringLength(30, MinimumLength = 4)]
        [Display(Name = "Card Holder", ShortName = "CardHol")]
        public string CardHolder { get; set; }

        [StringLength(10)]
        [Display(Name = "Cif No", ShortName = "Cif")]
        public string Cif { get; set; }

        [EnumDataType(typeof(RequestType))]
        [Display(Name = "Request Type", ShortName = "ReqType")]
        public RequestType Type { get; set; }

        [DataType(DataType.DateTime)]
        [Display(Name = "Request Date", ShortName = "ReqDate")]
        public DateTime RequestDate { get; set; }

        [Display(Name = "Card Location", ShortName = "CardLoc")]
        public long CardLocation { get; set; }

        [ForeignKey("CardLocation")]
        public virtual Department CardDepartment { get; set; }


        [Display(Name = "Pin Location", ShortName = "PinLoc")]
        public long PinLocation { get; set; }

        [ForeignKey("PinLocation")]
        public virtual Department PinDepartment { get; set; }

        [EnumDataType(typeof(RequestState))]
        [Display(Name = "State")]
        public RequestState State { get; set; }

        [StringLength(50)]
        [Display(Name = "Employee Name", ShortName = "Employee")]
        public string EmployeeName { get; set; }

        [StringLength(50)]
        [Display(Name = "Code")]
        public string Code { get; set; }

        [Display(Name = "Devide Destination", ShortName = "DevideDest")]
        public long DevideValue { get; set; }

        [ForeignKey("DevideValue")]
        public virtual Department DevideDepartment { get; set; }

        [StringLength(100)]
        [Display(Name = "Description")]
        public string Description { get; set; }
        
    }
}