//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Almwdeh.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class UsersAccessTbl
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public Nullable<int> UserRoleIDs { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> AccessFailedCount { get; set; }
        public Nullable<bool> LockoutEnabled { get; set; }
        public Nullable<bool> Verified { get; set; }
        public string ResetPasswordCode { get; set; }
    
        public virtual UsersRolesTbl UsersRolesTbl { get; set; }
    }
}
