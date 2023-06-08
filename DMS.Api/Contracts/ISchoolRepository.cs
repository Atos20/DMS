using System;
using DMS.Api.Models;

namespace DMS.Api.Contracts
{
	public interface ISchoolRepository : IGenericRepository<School>
	{
		Task<School?> GetSchoolByName(string schoolName);
	}
}

