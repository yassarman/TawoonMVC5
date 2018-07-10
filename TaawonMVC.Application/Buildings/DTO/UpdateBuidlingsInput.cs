using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Buildings.DTO
{
    [AutoMap(typeof(Models.Buildings))]
    public  class UpdateBuidlingsInput

    {
        [Required]
        public int Id { get; set; }

        [Required]
        public int buildingID { get; set; }

        [Required]
        public int numOfBuildingUnits { get; set; }

        [Required]
        public int numOfFloors { get; set; }

        [Required]
        [MaxLength(500, ErrorMessage = "Street name should be less than 500 character")]
        public string streetName { get; set; }

        [Required] 
        public int buildingNo { get; set; }

        [Required] 
        public int neighborhoodID { get; set; }
        public virtual Models.Neighborhood NeighboorHood { get; set; }

        [Required] 
        public int buildingTypeID { get; set; }
        public virtual Models.BuildingType BuildingType { get; set; }

        [MaxLength(500, ErrorMessage = "GISMAP should be less than 500 character")]
        public string GISMAP { get; set; }

        [Required] 
        public byte houshProperty { get; set; }

        [MaxLength(500, ErrorMessage = "House name should be less than 500 character")]
        public string houshName { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        //added for changes on table Buildings
        //-------
        [Required]
        public int buildingUsesID { get; set; }
        public virtual Models.BuildingUses BuildingUses { get; set; }
        [Required]
        public bool isInHoush { get; set; }

        public string buildingName { get; set; }
        //---------
    }
}
