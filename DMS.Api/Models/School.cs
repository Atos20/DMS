using System;
using System.Net;

namespace DMS.Api.Models
{
	public class School
	{
        public int SchoolId { get; set; }
        public string? SchoolName { get; set; }
        public string? DirectorName { get; set; }
        //Navigation Properties
        public virtual List<ClassRoom> ClassRooms { get; set; } = new List<ClassRoom>();
        public virtual List<Student> Students { get; set; } = new List<Student>();
        public virtual Address? Address { get; set; }
    }

}