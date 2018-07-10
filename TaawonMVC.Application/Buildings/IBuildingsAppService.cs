using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaawonMVC.Buildings.DTO;

namespace TaawonMVC.Buildings
{
  public  interface IBuildingsAppService:IApplicationService
    {
        IEnumerable<GetBuildingsOutput> getAllBuildings();
        GetBuildingsOutput getBuildingsById(GetBuidlingsInput input);
        Task create(CreateBuildingsInput input);
        void update(UpdateBuidlingsInput input);
        void delete(DeleteBuildingsInput input);
    }
}
