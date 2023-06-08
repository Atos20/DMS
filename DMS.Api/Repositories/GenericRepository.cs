using System;
using DMS.Api.Contracts;
using Microsoft.EntityFrameworkCore;

namespace DMS.Api.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
        private readonly DataContext _context;
        private readonly ILogger _logger;

        public GenericRepository(DataContext context, ILogger logger)
		{
            _context = context;
            _logger = logger;
        }

        public virtual async Task<T> AddAsync(T entity)
        {
            await _context.AddAsync(entity);
            await _context.SaveChangesAsync();
            return entity;
        }

        public virtual async Task DeleteAsync(int id)
        {
            var entity = await _context.Set<T>().FindAsync(id);
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public virtual async Task<bool> Exists(int id)
        {
            var entity = await GetAsync(id);
            return entity != null;
        }

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetAsync(int? id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public virtual async Task UpdateAsync(T entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}

