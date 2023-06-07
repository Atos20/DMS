using System;
namespace DMS.Api.Models
{
	public class Location
	{
		public Location()
		{
		}

        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        //Navigation Properties
        public virtual int AddressId { get; set; }
        public virtual Address Address { get; set; }

    }
}

