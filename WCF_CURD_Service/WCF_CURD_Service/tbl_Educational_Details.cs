//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCF_CURD_Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_Educational_Details
    {
        public int Educational_Details_Id { get; set; }
        public int Employee_Id { get; set; }
        public string Education { get; set; }
        public string University { get; set; }
        public string Grade_Obtained { get; set; }
        public string Passing_Year { get; set; }
        public bool Active_Status { get; set; }
    
        public virtual tbl_Employee_Master tbl_Employee_Master { get; set; }
    }
}
