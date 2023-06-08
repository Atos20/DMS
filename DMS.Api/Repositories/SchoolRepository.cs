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
        private readonly ILogger _logger;

        public SchoolRepository(DataContext context, ILogger logger) : base(context, logger)
		{
            _context = context;
            _logger = logger;
        }

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

