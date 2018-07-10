using Abp.Application.Services;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.BuildingUses.DTO;
using TaawonMVC.Models;

namespace TaawonMVC.BuildingUses
{
    public class BuildingUsesAppService : ApplicationService, IBuildingUsesAppService
    {
        private readonly IBuildingUsesManager _buildingUsesManager;

        public BuildingUsesAppService(IBuildingUsesManager buildingUsesManager)
        {
            _buildingUsesManager = buildingUsesManager;

        }
        public async Task create(CreateBuildingUsesInput input)
        {
            var output = Mapper.Map<CreateBuildingUsesInput, Models.BuildingUses>(input);
            await _buildingUsesManager.Create(output);
        }

        public void delete(DeleteBuildingUsesInput input)
        {
            _buildingUsesManager.Delete(input.id);
        }

        public IEnumerable<GetBuildingUsesOutput> getAllBuildingUses()
        {
            var getAllBuildingUses = _buildingUsesManager.GetAllList().ToList();
            var output = Mapper.Map<List<Models.BuildingUses>,List<GetBuildingUsesOutput>>(getAllBuildingUses);
            return output;
        }

        public GetBuildingUsesOutput getBuildingUsesById(GetBuildingUsesInput input)
        {
            var getBuildingUsesById = _buildingUsesManager.GetBuildingUsesById(input.id);
            var output = Mapper.Map<Models.BuildingUses, GetBuildingUsesOutput>(getBuildingUsesById);
            return output;
        }

        public void update(UpdateBuildingUsesInput input)
        {
            var output = Mapper.Map<UpdateBuildingUsesInput, Models.BuildingUses>(input);
            _buildingUsesManager.Update(output);
        }
    }
}
