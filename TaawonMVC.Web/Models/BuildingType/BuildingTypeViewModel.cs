using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaawonMVC.BuildingType.DTO;

namespace TaawonMVC.Web.Models.BuildingType
{
    public class BuildingTypeViewModel
    {
        public IEnumerable<GetBuildingTypeOutput> BuildingTypes { get; set; }
        public GetBuildingTypeOutput buildingTypeOutput { get; set; }
    }
}