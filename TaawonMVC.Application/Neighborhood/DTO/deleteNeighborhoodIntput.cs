using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Neighborhood.DTO
{
    [AutoMap(typeof(Models.Neighborhood))]
    public  class deleteNeighborhoodIntput
    {
        public int Id { get; set; }
    }
}
