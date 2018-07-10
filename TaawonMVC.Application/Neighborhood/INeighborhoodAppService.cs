using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.Neighborhood.DTO;

namespace TaawonMVC.Neighborhood
{
   public interface INeighborhoodAppService:IApplicationService
    {
        IEnumerable<getNeighborhoodOutput> GetAllNeighborhood();
        getNeighborhoodOutput getNeighborhoodById(getNeighborhoodIntput input);
        void update(updateNeighborhoodIntput input);
        void delete(deleteNeighborhoodIntput input);
        Task create(createNeighborhoodIntput input);
       
    }
}
