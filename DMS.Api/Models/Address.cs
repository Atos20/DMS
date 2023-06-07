using System;
namespace DMS.Api.Models
{
    public class Address
    {
        public Address()
        {
        }

        public int AddressId { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        //Navigation Properties
        public virtual Location Location { get; set; }
        public virtual School School { get; set; }
        public virtual Guardian Guardian { get; set; }
        //Foreing keys
        public int SchoolId { get; set; }
        public int GuardianId { get; set; }

    }
}

