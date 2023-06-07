using System;
namespace DMS.Api.Models
{
	public class Guardian
	{
        public int GuardianId { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Name { get; set; }
        //Navigation Properties
        public virtual ICollection<Child>? Children { get; set; }
        public virtual Address? Address { get; set; }
    }
}

