using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAppProject1.Models;
using WebAppProject1.Services;

namespace WebAppProject1.Controllers
{
    public class EmployeeController: Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public IActionResult Index()
        {
            var employees = _employeeService.GetAll().Select(employee => new EmployeeIndexViewModel
            {
                Id = employee.EmployeesId,
                HRId = employee.HRId,
                Emp_name= employee.Emp_name,
                ImageURL=employee.ImageURL,
                Emp_name_ENG=employee.Emp_name_ENG,
                JobTitleId = employee.JobTitleId,
                 Emp_email=employee.Emp_email,
                Last_updated_date=employee.Last_updated_date
    }).ToList();
           
                return View(employees);
        }
    }
}
