using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.BuildingType.DTO;

namespace TaawonMVC.BuildingType
{
   public interface IBuildingTypeAppService:IApplicationService
    { 
        // add this line to check for repository
        IEnumerable<GetBuildingTypeOutput> getAllBuildingtype();
        GetBuildingTypeOutput getBuildingTypeById(GetBuidlingTypeInput input);
        Task create(CreateBuildingTypeInput input);
        void update(UpdateBuidlingTypeInput input);
        void delete(DeleteBuildingTypeInput input);


    }
}
