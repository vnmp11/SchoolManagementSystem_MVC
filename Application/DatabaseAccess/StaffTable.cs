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
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Web;

    public partial class StaffTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StaffTable()
        {
            this.EmployeeLeavingTables = new HashSet<EmployeeLeavingTable>();
            this.EmployeeSalaryTables = new HashSet<EmployeeSalaryTable>();
            this.StaffAttendanceTables = new HashSet<StaffAttendanceTable>();
            this.TimeTblTables = new HashSet<TimeTblTable>();
        }
    
        public int StaffID { get; set; }
        public int User_ID { get; set; }
        [Required]
        public string Name { get; set; }
        public int Designation_ID { get; set; }
        [Required]
        public string ContactNo { get; set; }
        [Required]
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string Qualification { get; set; }
        public string Photo { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public string Gender { get; set; }
        public Nullable<double> BasicSalary { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public Nullable<System.DateTime> RegistrationDate { get; set; }
        [DataType(DataType.Upload)]
        [NotMapped]
        public HttpPostedFileBase PhotoFile { get; set; }

        public virtual DesignationTable DesignationTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeLeavingTable> EmployeeLeavingTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeSalaryTable> EmployeeSalaryTables { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StaffAttendanceTable> StaffAttendanceTables { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TimeTblTable> TimeTblTables { get; set; }
    }
}
