//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication5
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONTACT
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public Nullable<int> UserId { get; set; }
    
        public virtual USER USER { get; set; }
    }
}
