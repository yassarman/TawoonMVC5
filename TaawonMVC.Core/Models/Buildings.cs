using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Models
{
    public class Buildings : FullAuditedEntity
    {

        public Buildings()
        {
            //buildingID = 0;
            CreationTime = Clock.Now;
            numOfBuildingUnits = 0;
            numOfFloors = 0;
            streetName = "";
            buildingNo = 0;
            neighborhoodID = 0;
            buildingTypeID = 0;
          //  buildingUsesID = 0;
            GISMAP = "";
            isInHoush = false;
            buildingName = "";



        }
        //[Key]
        [Required]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        [ForeignKey("NeighboorHood")]
        public int neighborhoodID { get; set; }
        public virtual Neighborhood NeighboorHood { get; set; }

        [Required]
        [ForeignKey("BuildingUses")]
        public int buildingUsesID { get; set; }
        public virtual BuildingUses BuildingUses { get; set; }
        

        [Required]
        [ForeignKey("BuildingType")]
        public int buildingTypeID { get; set; }
        public virtual BuildingType BuildingType { get; set; }
        

        [MaxLength(500, ErrorMessage = "GISMAP should be less than 500 character")]
        public string GISMAP { get; set; }

        [Required]
        public byte houshProperty { get; set; }

        [MaxLength(500, ErrorMessage = "House name should be less than 500 character")]
        public string houshName { get; set; }

        public double X { get; set; }

        public double Y { get; set; }

        [Required]
        public bool isInHoush { get; set; }

        public string buildingName { get; set; }

    }
}
