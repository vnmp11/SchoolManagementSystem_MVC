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

    public partial class StudentTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StudentTable()
        {
            this.AttendanceTables = new HashSet<AttendanceTable>();
            this.ExamMarkTables = new HashSet<ExamMarkTable>();
            this.SchoolLeavingTables = new HashSet<SchoolLeavingTable>();
            this.StudentPromoteTables = new HashSet<StudentPromoteTable>();
            this.SubmissionFeeTables = new HashSet<SubmissionFeeTable>();
        }
    
        public int StudentID { get; set; }
        public int Session_ID { get; set; }
        public int Programe_ID { get; set; }
        public int User_ID { get; set; }
        public Nullable<int> ClassID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime DateofBirth { get; set; }
        public string Gender { get; set; }
        public string ContactNo { get; set; }
        public string Photo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public System.DateTime AddmissionDate { get; set; }
        public string PreviousSchool { get; set; }
        public Nullable<double> PreviousPercentage { get; set; }
        public string EmailAddress { get; set; }
        public string Address { get; set; }
        public string Nationality { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttendanceTable> AttendanceTables { get; set; }
        public virtual ClassTable ClassTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ExamMarkTable> ExamMarkTables { get; set; }
        public virtual ProgrameTable ProgrameTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SchoolLeavingTable> SchoolLeavingTables { get; set; }
        public virtual SessionTable SessionTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StudentPromoteTable> StudentPromoteTables { get; set; }
        public virtual UserTable UserTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubmissionFeeTable> SubmissionFeeTables { get; set; }
    }
}