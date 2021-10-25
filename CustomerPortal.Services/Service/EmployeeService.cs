using CustomerPortal.Data.Entity;
using CustomerPortal.Data.Implementation;
using CustomerPortal.Repositories.Abstraction;
using CustomerPortal.Repositories.Implementation;
using CustomerPortal.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPortal.Services.Service
{
    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository) : base()
        {
            _employeeRepository = employeeRepository;
        }

        public async Task Add(Employee employee)
        {
            await _employeeRepository.AddAsync(employee);
        }

        public async Task Remove(int id)
        {
            Employee employee = await _employeeRepository.GetByIdAsync(id);
            List<Employee> employeelist = new List<Employee>();
            employeelist.Add(employee);
            await _employeeRepository.RemoveRangeAsync(employeelist);
        }

        public async Task<Employee> GetById(int id)
        {
            return await _employeeRepository.GetByIdAsync(id);
        }

        public async Task Update(Employee employee)
        {
            await _employeeRepository.UpdateAsync(employee);
        }
    }
}
