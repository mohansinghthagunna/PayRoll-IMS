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
    
    public partial class DEPARTMENT
    {
        public DEPARTMENT()
        {
            this.EMP_TRAN = new HashSet<EMP_TRAN>();
        }
    
        public int DEPT_ID { get; set; }
        public string DEPT_PARENT { get; set; }
        public string DEPT_NAME { get; set; }
        public Nullable<int> LEVEL { get; set; }
        public string FLDTYPE { get; set; }
    
        public virtual ICollection<EMP_TRAN> EMP_TRAN { get; set; }
    }
}
