//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmployeeCertificationTable
    {
        public int EmployeeCertificationID { get; set; }
        public string CertificationName { get; set; }
        public string CertificationAuthority { get; set; }
        public string LevelCertification { get; set; }
        public Nullable<System.DateTime> FromYear { get; set; }
        public Nullable<int> EmployeeResumeID { get; set; }
        public int UserID { get; set; }
    
        public virtual UserTable UserTable { get; set; }
    }
}
