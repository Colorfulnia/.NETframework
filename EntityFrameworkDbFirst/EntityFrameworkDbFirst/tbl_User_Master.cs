//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFrameworkDbFirst
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_User_Master
    {
        public int User_Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Full_Name { get; set; }
        public Nullable<System.DateTime> Last_Login_Datetime { get; set; }
        public bool Active_Status { get; set; }
    }
}
