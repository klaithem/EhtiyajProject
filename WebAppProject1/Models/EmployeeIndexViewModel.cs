using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppProject1.Models
{
    public class EmployeeIndexViewModel
    {
        public int Id { get; set; }
        public int HRId { get; set; }      
        public String Emp_name { get; set; }      
        public String ImageURL { get; set; }
         public String Emp_name_ENG { get; set; }
        public int JobTitleId { get; set; }
         public String Emp_email { get; set; }          
        public DateTime Last_updated_date { get; set; }

    }
}
