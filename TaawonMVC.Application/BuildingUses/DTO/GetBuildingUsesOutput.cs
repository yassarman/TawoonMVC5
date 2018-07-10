using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.BuildingUses.DTO
{
    [AutoMap(typeof(Models.BuildingUses))]
 public class GetBuildingUsesOutput
     {
        public int id { get; set; }
        public string UsedFor { get; set; }
     }
}
