using Abp.Application.Services;
using Abp.Domain.Repositories;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.Models;

namespace TaawonMVC.BuildingType.DTO
{
   public class BuildingTypeAppService:ApplicationService,IBuildingTypeAppService
    {
        
        private readonly IBuildingTypeManager _buildingTypeManager;

        public BuildingTypeAppService(IBuildingTypeManager buildingTypeManager)
            
        {
            _buildingTypeManager = buildingTypeManager;
        }

        public async Task create(CreateBuildingTypeInput input)
        {
            var output = Mapper.Map<CreateBuildingTypeInput,Models.BuildingType>(input);
            await _buildingTypeManager.create(output);
        
        }

        public void delete(DeleteBuildingTypeInput input)
        {
            _buildingTypeManager.delete(input.Id);
        }

        public IEnumerable<GetBuildingTypeOutput> getAllBuildingtype()
        {
            var getBuildingType = _buildingTypeManager.getAllList().ToList();
            var output = Mapper.Map<List<Models.BuildingType>,List<GetBuildingTypeOutput>>(getBuildingType);
            return output;
        }

        public GetBuildingTypeOutput getBuildingTypeById(GetBuidlingTypeInput input)
        {
            var getBuildingType = _buildingTypeManager.getBuildingTypeById(input.Id);
             var output =   Mapper.Map<Models.BuildingType, GetBuildingTypeOutput>(getBuildingType);
            return output;
        }

        public void update(UpdateBuidlingTypeInput input)
        {
             var updateBuildingType = Mapper.Map<UpdateBuidlingTypeInput, Models.BuildingType>(input);
            _buildingTypeManager.update(updateBuildingType);
        }
    }
}

