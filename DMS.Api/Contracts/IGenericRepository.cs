using System;
namespace DMS.Api.Contracts
{
	public interface IGenericRepository<T> where T : class
	{
		Task<T> GetAsync(int? id);
		Task<IEnumerable<T>> GetAllAsync();
		Task<T> AddAsync(T entity);
		Task<bool> Exists(int id);
		Task DeleteAsync(int id);
		Task UpdateAsync(T enity);
	}
}

