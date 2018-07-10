using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Models
{
   public  interface IBuildingUsesManager:IDomainService
    {
        IEnumerable<BuildingUses> GetAllList();
        BuildingUses GetBuildingUsesById(int Id);
        Task<BuildingUses> Create(BuildingUses entity);
        void Update(BuildingUses entity);
        void Delete(int Id);
    }
}
