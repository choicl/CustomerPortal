using CustomerPortal.Data.Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerPortal.Web.DataInitial
{
	public class DefaultDataInitializer
	{
		private readonly CustomerPortalDbContext _dbContext;
		public DefaultDataInitializer(CustomerPortalDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public async Task Initialize()
		{
			await _dbContext.Clients.AddAsync(new Data.Entity.Employee() { FullName = "John" });
			await _dbContext.SaveChangesAsync();
		}
	}
}
