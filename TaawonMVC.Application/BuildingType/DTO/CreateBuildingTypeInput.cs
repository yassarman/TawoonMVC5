using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.Models;

namespace TaawonMVC.BuildingType.DTO
{
    [AutoMap(typeof(Models.BuildingType))]
    public class CreateBuildingTypeInput
    {   
        //public int Id { get; set; }
        public string AName { get; set; }
        public string EName { get; set; }
        public DateTime creationTime { get; set; }
    }
}
