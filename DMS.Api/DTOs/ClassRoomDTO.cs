using System;
namespace DMS.Api.DTOs
{
	public class ClassRoomDTO
	{
		public ClassRoomDTO()
		{
		}

        public int ClassRoomId { get; set; }
        public string? ClassRoomName { get; set; }
        public string? CourseName { get; set; }
        public string? ChildCareWorker { get; set; }
        public int ChildrenLimit { get; set; }
        public int StartAge { get; set; }
        public int EndAge { get; set; }
    }
}

