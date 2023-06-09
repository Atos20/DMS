using System;
using DMS.Api.Contracts;
using DMS.Api.DTOs;
using DMS.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace DMS.Api.Repositories
{
	public class SchoolRepository: GenericRepository<School>, ISchoolRepository
	{
        private readonly DataContext _context;
        private readonly ILogger<SchoolRepository> _logger;

        public SchoolRepository(DataContext context, ILogger<SchoolRepository> logger) : base(context, logger)
		{
            _context = context;
            _logger = logger;
        }

        /// <summary>
        ///  Gets All classrooms for a given school
        /// </summary>
        /// <param name="id">School Id</param>
        /// <returns></returns>
        public async Task<IEnumerable<ClassRoom>> GetClassroomsBySchoolId(int? id)
        {
            try
            {
                var classrooms = await (
                    from cr in _context.ClassRoom
                    where cr.SchoolId == id
                    select cr
                    ).ToListAsync();

                return classrooms;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it as needed
                _logger.LogError(ex, "An error occurred while retrieving schools.");
                throw;

            }
        }

        /// <summary>
        ///  Find the first element that matches the name
        /// </summary>
        /// <param name="string">Name of School</param>
        /// <returns></returns>
        public async Task<School?> GetSchoolByName(string schoolName)
        {
            try
            {
                var school = await _context.School.FirstOrDefaultAsync(school => school.SchoolName == schoolName);
                return (School?)school;
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

