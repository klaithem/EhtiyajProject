using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAppProject1.Entity
{
   
      // [Table("Employee")]
        public class Employee
        {
            [Key]
            [Display(Name = "التسلسل")]
            public int EmployeesId { get; set; }

            [Required]
            [Display(Name = "الرقم المالي")]
            public int HRId { get; set; }
        [Required, MaxLength(100)]
        [Display(Name = "اسم الموظف بالكامل")]
            public String Emp_name { get; set; }

            [Display(Name = "الصورة")]
            public String ImageURL { get; set; }
        [Required, MaxLength(100)]
        [Display(Name = "اسم الموظف بالكامل-بالانجليزي")]
            public String Emp_name_ENG { get; set; }
        [Required, MaxLength(100)]
        [Display(Name = "المسمى الوظيفي")]
            public int JobTitleId { get; set; }
        [Required, MaxLength(100)]
        [Display(Name = "البريد الالكتروني")]
            public String Emp_email { get; set; }

        [Display(Name = "تاريخ  اخر تحديث")]

        public DateTime Last_updated_date { get; set; }


        //[Display(Name = "القسم")]
        //public int SectionsId { get; set; }

        //[Display(Name = "الإدارة")]
        //public int DepartmentsId { get; set; }

        //[Display(Name = "القطاع")]
        //public int SectorsId { get; set; }


        //[Display(Name = "رقم المكتب")]
        //public int Emp_direct { get; set; }

        //[Display(Name = "رقم الهاتف المحمول")]
        //public int Emp_mobile { get; set; }


        //[Display(Name = "المستخدم")]
        //public String UserId { get; set; }

        //[Display(Name = " الاعداد من قبل")]
        //public String AdminId { get; set; }

        //[Display(Name = "تاريخ الاعداد")]

        //public DateTime Issued_date { get; set; }

        //[Display(Name = " التحديث من قبل")]
        //public String UpdatedAdminId { get; set; }


        //public virtual Sections Sections { get; set; }

        //public virtual Departments Departments { get; set; }


        ////public virtual Sectors Sectors { get; set; }
        //public virtual JobTitle JobTitle { get; set; }

        public IEnumerable<Pro_initial> Pro_initials { get; set; }







    }
}
