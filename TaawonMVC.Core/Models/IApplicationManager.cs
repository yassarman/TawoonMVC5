using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaawonMVC.Models
{
   public interface IApplicationManager :IDomainService
    {
        IEnumerable<Application> getAllList();
        Application getApplicationById(int id);
        Task<Application> Create(Application entity);
        void Update(Application entity);
        void Delete(int id);
    }
}
