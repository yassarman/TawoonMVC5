using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.BuildingType.DTO
{
    [AutoMap(typeof(Models.BuildingType))]
    public  class UpdateBuidlingTypeInput
    {
        public int Id { get; set; }
        public string AName { get; set; }
        public string EName { get; set; }
    }
}
