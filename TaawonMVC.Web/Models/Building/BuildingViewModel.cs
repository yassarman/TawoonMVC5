using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TaawonMVC.Buildings.DTO;
using TaawonMVC.BuildingType.DTO;
using TaawonMVC.BuildingUses.DTO;
using TaawonMVC.Neighborhood.DTO;

namespace TaawonMVC.Web.Models.Building
{
    public class BuildingViewModel
    {
       public  IEnumerable<GetBuildingsOutput> Buildings { get; set; }
       public  GetBuildingsOutput Building { get; set; }
    // public  getNeighborhoodOutput neighborhood { get; set; }
       public  IEnumerable<GetBuildingTypeOutput> BuildingTypes { get; set; }
       public  IEnumerable<getNeighborhoodOutput> Neighborhoods { get; set; }
    // public  GetBuildingTypeOutput BuildingType { get; set; }
    // public  getNeighborhoodOutput Neighborhood { get; set; }
       public  SelectList YesOrNo { get; set; }
       public  string[] HoushNameArray { get; set; }
       public  IEnumerable<GetBuildingUsesOutput> BuildingUses { get; set; }
        //------to upload files 
        [Required(ErrorMessage = "Please select file.")]
        [Display(Name = "Browse File")]
        public HttpPostedFileBase[] files { get; set; }
        //-----------


    }
}