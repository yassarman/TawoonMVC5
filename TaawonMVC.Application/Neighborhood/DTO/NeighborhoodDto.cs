using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.Models;

namespace TaawonMVC.Neighborhood.DTO
{
    [AutoMap(typeof(Models.Neighborhood))]

    public class NeighborhoodDto : EntityDto, IHasCreationTime
    {
       
        [Required]
        [MinLength(1,ErrorMessage ="Arabic name should not be less than one character")]
        public string AName { get; set; }

        [Required]
        public string EName { get; set; }

        public DateTime CreationTime { get; set ; }
    }
}
