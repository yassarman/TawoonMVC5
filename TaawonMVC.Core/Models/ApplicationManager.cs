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
   public class ApplicationManager :DomainService, IApplicationManager
    {
        private readonly IRepository<Application> _IRepositoryApplication;
        public ApplicationManager(IRepository<Application> irepositoryApplication)
        {
           _IRepositoryApplication = irepositoryApplication;
        }

        public async Task<Application> Create(Application entity)
        {
            var application = _IRepositoryApplication.FirstOrDefault(x => x.Id == entity.Id);
            if(application!=null)
            {
                throw new UserFriendlyException("Application already exist");
            }
            else
            {
                return await _IRepositoryApplication.InsertAsync(entity);
            }
        }

        public void Delete(int id)
        {
            
            try
            {
                var application = _IRepositoryApplication.Get(id);
                _IRepositoryApplication.Delete(application);
            }
            catch (Exception)
            {

                throw new UserFriendlyException(id,"Application is not exist");
            }
            
        }

        public IEnumerable<Application> getAllList()
        {
            return _IRepositoryApplication.GetAllIncluding(x=>x.Id);
        }

        public Application getApplicationById(int id)
        {
            return _IRepositoryApplication.Get(id);
        }

        public void Update(Application entity)
        {
            _IRepositoryApplication.Update(entity);
        }
    }
}
