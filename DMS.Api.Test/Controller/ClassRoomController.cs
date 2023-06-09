using System;
using AutoMapper;
using DMS.Api.Contracts;
using DMS.Api.DTOs;
using DMS.Api.Models;
using FakeItEasy;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;

namespace DMS.Api.Test.Controller
{
	public class ClassRoomController
	{
        private readonly IClassRoomRepository _classRoomRepositoryFake;
        private readonly IMapper _mapperFake;

        public ClassRoomController()
        {
            _classRoomRepositoryFake = A.Fake<IClassRoomRepository>();
            _mapperFake = A.Fake<IMapper>();

        }

        [Fact]
        public void GetClassRoomDetails_ReturnsOKResponse()
        {
            // Arrange

            // Create a list of schools to be returned by the repository
            var classroom = A.Fake<ClassRoom>();
            var classroomsDTO = A.Fake<ClassRoomDTO>();
            // Fake mapper
            A.CallTo(() => _mapperFake.Map<ClassRoomDTO>(classroom)).Returns(classroomsDTO);

            // Configure the fake repository to return the list of schools
            A.CallTo(() => _classRoomRepositoryFake.GetClassroomDetails(1)).Returns(classroom);

            // Create an instance of the controller and pass the fake dependencies
            var classRoomController = new DMS.Api.Controllers.ClassRoomController(_mapperFake, _classRoomRepositoryFake);

            // Act
            var response = classRoomController.GetClassroomDetails(1);
            // Assert
            response.Should().NotBeNull();
            response.Result.Should().BeOfType<ActionResult<ClassRoomDTO>>();
            response.Result.Result.Should().BeOfType<OkObjectResult>();
            response.Result.Result.As<OkObjectResult>().StatusCode.Should().Be(200);
        }
    }
}

