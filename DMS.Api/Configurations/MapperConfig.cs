using System;
using AutoMapper;
using DMS.Api.DTOs;
using DMS.Api.Models;

namespace DMS.Api.Configurations
{
	public class MapperConfig : Profile
	{
		public MapperConfig()
		{
			CreateMap<School, SchoolDTO>().ReverseMap();
			CreateMap<ClassRoom, ClassRoomDTO>().ReverseMap();
		}
	}
}

