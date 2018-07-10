using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TaawonMVC.Neighborhood.DTO;

namespace TaawonMVC.Web.Models.Neighborhood
{
    public class NeighborhoodViewModel
    {
        public IEnumerable<getNeighborhoodOutput> Neighborhoods { get; set; }
        public getNeighborhoodOutput Neighborhood { get; set; }
    }
}