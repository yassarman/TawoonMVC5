using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.Models;
using TaawonMVC.Neighborhood.DTO;

namespace TaawonMVC.Neighborhood
{
  public class NeighborhoodAppService:ApplicationService,INeighborhoodAppService
    {
        private readonly Models.INeighborhoodManager _neighborhoodManager;
        public NeighborhoodAppService(Models.INeighborhoodManager neighborhoodManager)
        {
            _neighborhoodManager = neighborhoodManager;
        }

        public async Task create(createNeighborhoodIntput input)
        {
            var output = Mapper.Map<createNeighborhoodIntput, Models.Neighborhood>(input);
           await _neighborhoodManager.Create(output);
        }

        public void delete(deleteNeighborhoodIntput input)
        {
            
            _neighborhoodManager.Delete(input.Id);
        }

        public IEnumerable<getNeighborhoodOutput> GetAllNeighborhood()
        {
            var getAllList = _neighborhoodManager.getAllList().ToList();
            var output = Mapper.Map<List<Models.Neighborhood>, List<getNeighborhoodOutput>>(getAllList);
            return output;
        }

        public getNeighborhoodOutput getNeighborhoodById(getNeighborhoodIntput input)
        {
            var getNeighborhoodById = _neighborhoodManager.getNeighborhoodById(input.Id);
            var output = Mapper.Map<Models.Neighborhood, getNeighborhoodOutput>(getNeighborhoodById);
            return output;
        }

        public void update(updateNeighborhoodIntput input)
        {
            var output = Mapper.Map<updateNeighborhoodIntput, Models.Neighborhood>(input);
            _neighborhoodManager.Update(output);
            
        }
    }
}
