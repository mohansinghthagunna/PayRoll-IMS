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
    
    public partial class DASHINALLOWANCE
    {
        public DASHINALLOWANCE()
        {
            this.DASHINALLOWANCE_DETAIL = new HashSet<DASHINALLOWANCE_DETAIL>();
        }
    
        public int Id { get; set; }
        public int BSYear { get; set; }
        public System.DateTime CalcDate { get; set; }
        public string TrnUser { get; set; }
    
        public virtual ICollection<DASHINALLOWANCE_DETAIL> DASHINALLOWANCE_DETAIL { get; set; }
    }
}
