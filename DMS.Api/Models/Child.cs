using System;
namespace DMS.Api.Models
{
	public class Child
	{
		public Child()
		{
		}

        public int ChildId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public DateTime DateOfBirth { get; set; }

        //Navigation
        public int ClassRoomId { get; set; }
        public virtual ClassRoom ClassRoom { get; set; }
        public virtual School School { get; set; }
        public int SchoolId { get; set; }
        public virtual ICollection<Guardian> Guardians { get; set; }
    }
}

