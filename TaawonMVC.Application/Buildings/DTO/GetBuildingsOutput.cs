using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.Models;

namespace TaawonMVC.Buildings.DTO
{
  public  class GetBuildingsOutput
    {
        public int Id { get; set; }
        public int buildingID { get; set; }
        public int numOfBuildingUnits { get; set; }
        public int numOfFloors { get; set; }
        public string streetName { get; set; }
        public int buildingNo { get; set; }
        public int neighborhoodID { get; set; }
        public Models.Neighborhood NeighboorHood { get;set;}
        
        public int buildingTypeID { get; set; }
        public Models.BuildingType BuildingType { get; set; }
        public string GISMAP { get; set; }
        public byte houshProperty { get; set; }
        public string houshName { get; set; }
        public double X { get; set; }
        public double Y { get; set; }
        //added for changes on table Buildings
        //-------
       
        public int buildingUsesID { get; set; }
        public Models.BuildingUses BuildingUses { get; set; }
        public bool isInHoush { get; set; }
        public string buildingName { get; set; }
        //---------
    }
}
