using Abp.Domain.Repositories;
using Abp.Domain.Services;
using Abp.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Models
{
   public class BuildingTypeManager :DomainService,IBuildingTypeManager 
    {
        private readonly IRepository<BuildingType> _repositoryBuildingType;

        public BuildingTypeManager(IRepository<BuildingType> repositoryBuildingType)
        {
            _repositoryBuildingType = repositoryBuildingType;
        }

        public async Task<BuildingType> create(BuildingType entity)
        {
            var buildingType = _repositoryBuildingType.FirstOrDefault(x => x.Id == entity.Id);
            if(buildingType!=null)
            {
                throw new UserFriendlyException("Building type already exist");
            }
               else
            {
               return  await _repositoryBuildingType.InsertAsync(entity);
            }
        }

        public void delete(int id)
        {
            try
            {
                var buildingType = _repositoryBuildingType.Get(id);
                _repositoryBuildingType.Delete(buildingType);
            }
            catch (Exception)
            {

                throw new UserFriendlyException("Building Type not exist");
            }
           

        }

        public IEnumerable<BuildingType> getAllList()
        {
            return _repositoryBuildingType.GetAll();
        }

        public BuildingType getBuildingTypeById(int id)
        {
           return  _repositoryBuildingType.Get(id);
        }

        public void update(BuildingType entity)
        {
            _repositoryBuildingType.Update(entity);
        }
    }
}
