using Abp.Application.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.Buildings.DTO;
using TaawonMVC.Models;

namespace TaawonMVC.Buildings
{
    public class BuildingsAppService : ApplicationService, IBuildingsAppService
    {
        private readonly IBuildingsManager _buildings_Manager;

        public BuildingsAppService(IBuildingsManager buildings_Manager )
        {
            _buildings_Manager = buildings_Manager;
        }
        public async Task create(CreateBuildingsInput input)
        {
            var output = Mapper.Map<CreateBuildingsInput, Models.Buildings>(input);
             await _buildings_Manager.create(output);
        }

        public void delete(DeleteBuildingsInput input)
        {
            _buildings_Manager.delete(input.Id);
        }

        public IEnumerable<GetBuildingsOutput> getAllBuildings()
        { var getAllBuilding = _buildings_Manager.getAllList().ToList();
            var output = Mapper.Map<List<Models.Buildings>,List<GetBuildingsOutput>>(getAllBuilding);
            return output;
        }

        public GetBuildingsOutput getBuildingsById(GetBuidlingsInput input)
        {
            var getBuildingById = _buildings_Manager.getBuildingsById(input.Id);
            var output = Mapper.Map<Models.Buildings, GetBuildingsOutput>(getBuildingById);
            return output;
        }  

        public void update(UpdateBuidlingsInput input)
        {
            var output = Mapper.Map<UpdateBuidlingsInput, Models.Buildings>(input);
            _buildings_Manager.update(output);
        }
    }
}
