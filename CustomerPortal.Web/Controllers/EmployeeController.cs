using CustomerPortal.Data.Entity;
using CustomerPortal.Services.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CustomerPortal.Repositories;
using CustomerPortal.Services.Interface;
using CustomerPortal.Web.ServiceModel;

namespace CustomerPortal.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeeService _employeeService;

        public EmployeeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        public async Task<Employee> GetbyId(int Id)
        {
            return await _employeeService.GetById(Id);
        }

        [HttpPost]
        public async Task Add(Employee employee)
        {
            Employee newclient = new Employee() { FullName = employee.FullName, EmployeeId = employee.EmployeeId };
            await _employeeService.Add(employee);
        }


        [HttpPut]
        public async Task Update(EmployeeModel employeemodel)
        {
            Employee employee = await _employeeService.GetById(employeemodel.Id);
            employee.FullName = employeemodel.FullName;
            await _employeeService.Update(employee);
        }

        [HttpDelete]
        public async Task Remove(int id)
        {
            await _employeeService.Remove(id);
        }
    }
}
