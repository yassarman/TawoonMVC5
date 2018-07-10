using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Neighborhood.DTO
{
    [AutoMap(typeof(Models.Neighborhood))]
    public class createNeighborhoodIntput
    {
      //  public int Id { get; set; }
        public string AName { get; set; }
        public string EName { get; set; }
        public DateTime creationTime { get; set; }

    }
}
