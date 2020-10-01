﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebAppProject1.Entity;

namespace WebAppProject1.Services
{
  public  interface IEmployeeService
    {
        Task CreateAsync(Employee newEmployee);
        Employee GetById(int employeeId);
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(int id);
        Task Delete(int employeeId);
        //decimal UnionFees(int Id);
        //decimal StudentLoadRepaymentAmount(int id, decimal totalAmount);
        IEnumerable<Employee> GetAll();
    } 
}
