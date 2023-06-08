using AutoMapper;
using DMS.Api.Contracts;
using DMS.Api.Controllers;
using DMS.Api.Models;
using Microsoft.Extensions.Logging;
using FakeItEasy;
using DMS.Api.Repositories;
using DMS.Api.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Collections;
using FluentAssertions;

namespace DMS.Api.Test.Controller
{
    public class SchoolController
    {
        private readonly ISchoolRepository _schoolRepositoryFake;
        private readonly IMapper _mapperFake;

        public SchoolController()
        {
            _schoolRepositoryFake = A.Fake<ISchoolRepository>();
            _mapperFake = A.Fake<IMapper>();

        }
        [Fact]
        public void GetSchools_ReturnsOKResponse()
        {
            // Arrange

            // Create a list of schools to be returned by the repository
            var schools = A.Fake<ICollection<School>>();
            var schoolsDTOs = A.Fake<List<SchoolDTO>>();
            // Fake mapper
            A.CallTo(() => _mapperFake.Map<List<SchoolDTO>>(schools)).Returns(schoolsDTOs);

            // Configure the fake repository to return the list of schools
            A.CallTo(() => _schoolRepositoryFake.GetAllAsync()).Returns(schools);

            // Create an instance of the controller and pass the fake dependencies
            var schoolController = new DMS.Api.Controllers.SchoolController(_mapperFake, _schoolRepositoryFake);

            // Act
            var response = schoolController.GetSchools();
            // Assert
            response.Should().NotBeNull();
            response.Result.Should().BeOfType<ActionResult<List<SchoolDTO>>>();
            response.Result.Result.Should().BeOfType<OkObjectResult>();
            response.Result.Result.As<OkObjectResult>().StatusCode.Should().Be(200);
        }
    }
}
