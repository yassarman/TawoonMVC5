using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Neighborhood.DTO
{
   public class getNeighborhoodOutput
    {   
        
        public int Id { get; set; }
        public string AName { get; set; }
        public string EName { get; set; }
    }
}
