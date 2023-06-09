using System;
using DMS.Api.Contracts;
using DMS.Api.Models;
using Microsoft.CodeAnalysis.Completion;
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
        ///  Gets classroom details 
        /// </summary>
        /// <param name="id">This ID should be the ClassRoomId!!</param>
        /// <returns></returns>
        public async Task<ClassRoom?> GetClassroomDetails(int? id)
        {
            try
            {
                var query = from classroom in _context.ClassRoom
                     join child in _context.Child on classroom.ClassRoomId equals child.ClassRoomId into children
                     where classroom.ClassRoomId == id
                     select new ClassRoom
                     {
                         ClassRoomId = classroom.ClassRoomId,
                         ClassRoomName = classroom.ClassRoomName,
                         CourseName = classroom.CourseName,
                         ChildCareWorker = classroom.ChildCareWorker,
                         ChildrenLimit = classroom.ChildrenLimit,
                         StartAge = classroom.StartAge,
                         EndAge = classroom.EndAge,
                         Children = children.ToList()
                     };

                ClassRoom? cr = await query.FirstOrDefaultAsync();

                if (cr != null)
                {
                  return cr;
                }

                return new ClassRoom();
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
