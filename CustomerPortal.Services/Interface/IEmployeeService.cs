using CustomerPortal.Data.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPortal.Services.Interface
{
    public interface IEmployeeService
    {
        Task Add(Employee employee);
        Task Remove(int id);
        Task<Employee> GetById(int id);
        Task Update(Employee employee);

    }
}
