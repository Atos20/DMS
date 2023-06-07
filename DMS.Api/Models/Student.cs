using System;
namespace DMS.Api.Models
{
	public class Student : Child
	{

		//Navigation Properties
		public virtual int SchoolId { get; set; }
		public virtual School School { get; set; }

    }
}

