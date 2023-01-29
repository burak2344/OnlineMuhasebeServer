﻿using Microsoft.EntityFrameworkCore;
using OnlineMuhasebeServer.Domain.UnitOfWorks;
using OnlineMuhasebeServer.Persistance.Context;

namespace OnlineMuhasebeServer.Persistance
{
	public sealed class UnitOfWork : IUnitOfWork
	{
		private CompanyDbContext _context;	
		public void SetDbContextInstance(DbContext context)
		{
			_context = (CompanyDbContext)context;
		}

		public async Task<int> SaveChangesAsync()
		{
			int count = await _context.SaveChangesAsync();
			return count;
		}
	}
}
