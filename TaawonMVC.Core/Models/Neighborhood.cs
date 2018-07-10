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
   public class Neighborhood :FullAuditedEntity
    {
        

        public Neighborhood()
        {
            CreationTime = Clock.Now;
            AName = "Deleted";
            EName = "Deleted";
        }

        [Required]
        [MaxLength(200, ErrorMessage = "length should be less than 20 character")]
        public string AName { get; set; }

        [Required]
        [MaxLength(200, ErrorMessage = "length should be less than 20 character")]
        public string EName { get; set; }


    }
}
