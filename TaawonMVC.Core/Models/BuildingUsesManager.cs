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
    public class BuildingUsesManager : DomainService, IBuildingUsesManager
    {
        private readonly IRepository<BuildingUses> _IRepositoryBuildingUses;

        public BuildingUsesManager(IRepository<BuildingUses> IRepositoryBuildingUses)
        {
            _IRepositoryBuildingUses = IRepositoryBuildingUses;

        }
        public async Task<BuildingUses> Create(BuildingUses entity)
        {
            var BuildingUse = _IRepositoryBuildingUses.FirstOrDefault(b => b.Id == entity.Id);
            if(BuildingUse!=null)
            {
                throw new UserFriendlyException("Building Uses Is Already Exist");
            }
            else
            {
                return await _IRepositoryBuildingUses.InsertAsync(entity);
            }
          

        }

        public void Delete(int id)
        {
            try
            {
                var Output = _IRepositoryBuildingUses.Get(id);
                _IRepositoryBuildingUses.Delete(Output);
            }
            catch (Exception)
            {

                throw new UserFriendlyException("Building Uses Is Not Exist");
            }
            
        }

        public IEnumerable<BuildingUses> GetAllList()
        {
            var BuildingUses = _IRepositoryBuildingUses.GetAll();
            return BuildingUses;

        }

        public BuildingUses GetBuildingUsesById(int Id)
        {
            return _IRepositoryBuildingUses.Get(Id);
        }

        public void Update(BuildingUses entity)
        {
            _IRepositoryBuildingUses.Update(entity);
        }
    }
}
