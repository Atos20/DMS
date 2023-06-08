using System;
using System.Collections.Generic;
using DMS.Api.Models;

namespace DMS.Api.Contracts
{
	public interface IClassRoomRepository : IGenericRepository<ClassRoom>
	{
		Task<IEnumerable<ClassRoom>> GetClassroomsById(int? id);
	}
}

