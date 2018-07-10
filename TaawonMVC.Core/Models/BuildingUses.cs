using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Models
{
  public  class BuildingUses: FullAuditedEntity
    {
        public BuildingUses()
        {
            Id = 0;
            CreationTime = Clock.Now;
            IsDeleted = false;
            UsedFor = "";
        }
        

        [Required]
        public string UsedFor { get; set; }
    }
}
