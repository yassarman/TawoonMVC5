using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Models
{
  public  interface IBuildingTypeManager : IDomainService
    {

         IEnumerable<BuildingType> getAllList();
         BuildingType getBuildingTypeById(int id);
         Task<BuildingType> create(BuildingType entity);
         void update(BuildingType entity);
         void delete(int id);


    }
}
