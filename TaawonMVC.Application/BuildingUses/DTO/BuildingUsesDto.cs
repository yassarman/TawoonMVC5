using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.BuildingUses.DTO
{
    [AutoMap(typeof(Models.BuildingUses))]
  public  class BuildingUsesDto:EntityDto,IHasCreationTime
    {
        public int id { get; set; }
        public string UsedFor { get; set; }
        public DateTime CreationTime { get;set; }

    }
}
