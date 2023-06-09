using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using DMS.Api.Contracts;
using DMS.Api.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassRoomController : ControllerBase
    {
        private readonly IClassRoomRepository _classRoomRepository;
        private readonly IMapper _mapper;

        public ClassRoomController(IMapper mapper, IClassRoomRepository classRoomRepository)
        {
            _classRoomRepository = classRoomRepository;
            _mapper = mapper;
        }
        // GET: api/Classroom/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassRoomDTO>>GetClassroomDetails(int id)
        {
            try
            {
                var classroom = await _classRoomRepository.GetClassroomDetails(id);
                var classroomDTO = _mapper.Map<ClassRoomDTO>(classroom);
                return Ok(classroomDTO);
            }
            catch (Exception ex)
            {
                var problemDetails = new ProblemDetails
                {
                    Status = StatusCodes.Status500InternalServerError,
                    Title = "An error occurred while retrieving schools.",
                    Detail = ex.Message,
                };

                return StatusCode(StatusCodes.Status500InternalServerError, problemDetails);
            }

        }

        // GET: api/ClassRoom
        [HttpGet]
        public string Get()
        {
            return "value";
        }

        // POST: api/ClassRoom
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/ClassRoom/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ClassRoom/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
