using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.BuildingUses.DTO;

namespace TaawonMVC.BuildingUses
{
   public interface IBuildingUsesAppService:IApplicationService
    {
        IEnumerable<GetBuildingUsesOutput> getAllBuildingUses();
        GetBuildingUsesOutput getBuildingUsesById(GetBuildingUsesInput input);
        Task create(CreateBuildingUsesInput input);
        void delete(DeleteBuildingUsesInput input);
        void update(UpdateBuildingUsesInput input);
    }
}
