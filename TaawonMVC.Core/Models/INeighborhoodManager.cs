using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Models
{
   public interface INeighborhoodManager : IDomainService
    {
            IEnumerable<Neighborhood> getAllList();
            Neighborhood getNeighborhoodById(int id);
            Task<Neighborhood> Create(Neighborhood entity);
            void Update(Neighborhood entity);
            void Delete(int id);
        
    }
}
