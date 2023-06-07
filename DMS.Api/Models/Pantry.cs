using System;
namespace DMS.Api.Models
{
	public class Pantry
	{

        public int PantryId { get; set; }
        public int DiaperCount { get; set; }
        public int UsedDiapers { get; set; }
        public int MinimunRequiredDiapers { get; set; } = 10;
        public int ClothChangesCount { get; set; }
        public bool NeedsClothes { get; set; }
        public int MinimunRequiredChanges { get; set; } = 3;
        public int MilkBottleCount { get; set; }
        public bool NeedsMoreBottles { get; set; }
        public int MinimunRequiredBottles { get; set; } = 3;
        public double Sunscreen { get; set; }
        public bool NeedsMoreSunscreen { get; set; }
        //Navigation Properties
        public virtual int ClassRoomId { get; set; }
        public virtual ClassRoom? ClassRoom { get; set; }
    }
}

