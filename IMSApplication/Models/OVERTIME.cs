//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IMSApplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OVERTIME
    {
        public long OT_ID { get; set; }
        public int Emp_Id { get; set; }
        public System.DateTime OT_InDate { get; set; }
        public string OT_InTime { get; set; }
        public string OT_InMode { get; set; }
        public string OT_InRemarks { get; set; }
        public Nullable<System.DateTime> OT_OutDate { get; set; }
        public string OT_OutTime { get; set; }
        public string OT_OutMode { get; set; }
        public string OT_OutRemarks { get; set; }
        public Nullable<decimal> OT_Hours { get; set; }
        public Nullable<decimal> OT_Rate { get; set; }
        public string OT_Remarks { get; set; }
        public Nullable<bool> OT_ISHALTED { get; set; }
        public string OT_Type { get; set; }
        public Nullable<int> OT_ApprovedBy { get; set; }
        public string TrnUser { get; set; }
    
        public virtual EMP_DETAIL EMP_DETAIL { get; set; }
    }
}