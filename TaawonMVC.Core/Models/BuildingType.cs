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
   public class BuildingType :FullAuditedEntity
    {
        public BuildingType()
        {
            CreationTime = Clock.Now;
            AName = "Deleted";
            EName = "Deleted";
        }
        [Required]
        [StringLength(200,ErrorMessage ="Arabic name should be less than 20 character")]
        public string AName { get; set; }
        [Required]
        [StringLength(200,ErrorMessage ="English name should be less than 20 character")]
        public string EName { get; set; }
    }
}
