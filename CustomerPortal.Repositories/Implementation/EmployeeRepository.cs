using CustomerPortal.Data.Entity;
using CustomerPortal.Data.Implementation;
using CustomerPortal.Repositories.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerPortal.Repositories.Implementation
{
    public class EmployeeRepository : BaseRepository<Employee, CustomerPortalDbContext>, IEmployeeRepository
    {
        private readonly CustomerPortalDbContext _dbContext;
        public EmployeeRepository(
            CustomerPortalDbContext dbContext
            ) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
