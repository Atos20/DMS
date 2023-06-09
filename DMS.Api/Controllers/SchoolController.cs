﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DMS.Api;
using DMS.Api.Models;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using DMS.Api.DTOs;
using DMS.Api.Contracts;
using DMS.Api.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DMS.Api.Controllers
{
    [Route("api/[controller]")]
    public class SchoolController : ControllerBase
    {
        private readonly ISchoolRepository _schoolRepository;
        private readonly IMapper _mapper;

        public SchoolController(IMapper mapper, ISchoolRepository schoolRepository)
        {
            _schoolRepository = schoolRepository;
            _mapper = mapper;
        }
        // GET: api/ClassRoom
        // should return the information about the Schools register, we need just the  ID and Name
        [HttpGet]
        public async Task<ActionResult<List<SchoolDTO>>> GetSchools()
        {
            try
            {
                var schoolsDTO = _mapper.Map<List<SchoolDTO>>(await _schoolRepository.GetAllAsync());
                return Ok(schoolsDTO);
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

        // GET: api/Classroom/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<ClassRoomDTO>>> GetClassroomsBySchoolId(int id)
        {
            try
            {
                var classrooms = await _schoolRepository.GetClassroomsBySchoolId(id);
                var classroomsDTO = _mapper.Map<List<ClassRoomDTO>>(classrooms);
                return Ok(classroomsDTO);
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

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

