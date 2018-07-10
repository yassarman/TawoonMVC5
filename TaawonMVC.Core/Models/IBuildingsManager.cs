using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Models
{
  public  interface IBuildingsManager : IDomainService
    {
        IEnumerable<Buildings> getAllList();
        Buildings getBuildingsById(int id);
        Task<Buildings> create(Buildings entity);
        void update(Buildings entity);
        void delete(int id);
    }
}
