using System;
using System.Diagnostics;

namespace DMS.Api.Models
{
	public class ClassRoom
	{
        public int ClassRoomId { get; set; }
        public string? ClassRoomName { get; set; }
        public string? CourseName { get; set; }
        public string? ChildCareWorker { get; set; }
        public int ChildrenLimit { get; set; }
        public int StartAge { get; set; }
        public int EndAge { get; set; }
        //Navigation Properties
        public virtual Pantry? Pantry { get; set; }
        public virtual int SchoolId { get; set; }
        public virtual School? School { get; set; }
        public virtual ICollection<Activity>? Activities { get; set; }
        public virtual ICollection<Child>? Children { get; set; }
    }
}

