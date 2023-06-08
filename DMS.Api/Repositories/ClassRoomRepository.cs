using System;
using DMS.Api.Contracts;
using DMS.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Api.Repositories
{
    public class ClassRoomRepository : GenericRepository<ClassRoom>, IClassRoomRepository
    {
        private readonly DataContext _context;
        private readonly ILogger<ClassRoomRepository> _logger;

        public ClassRoomRepository(DataContext context, ILogger<ClassRoomRepository> logger) : base(context, logger)
        {
            _context = context;
            _logger = logger;
        }

        /// <summary>
        ///  Gets classrooms for a given school
        /// </summary>
        /// <param name="id">Corresponds the School ID associated with each classroom</param>
        /// <returns></returns>
        public async Task<IEnumerable<ClassRoom>> GetClassroomsById(int? id)
        {
            try
            {
                var classrooms = await _context.ClassRoom
                    .Where(cr => cr.SchoolId == id)
                    .ToListAsync();
                return classrooms;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError(ex, "An error occurred while retrieving schools.");
                throw;

            }
        }
    }
}
