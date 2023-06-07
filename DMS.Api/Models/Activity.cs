using System;
namespace DMS.Api.Models
{
	public class Activity
	{
		public Activity()
		{
		}

        public string ActivityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int AgeGroup { get; set; }
        public string MaterialsNeeded { get; set; }
        public string LeadBy { get; set; }
        //Navigation properties
        public virtual ICollection<ClassRoom> ClassRoom { get; set; }
    }
}

