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
   public class NeighborhoodManager:DomainService, INeighborhoodManager
    {
        private readonly IRepository<Neighborhood> _IRepositoryNeighborhood;

        public NeighborhoodManager(IRepository<Neighborhood> iRepositoryNeighborhood)
        {
            _IRepositoryNeighborhood = iRepositoryNeighborhood;
        }
        // Insert new neighborhood to the databse 
        public async Task<Neighborhood> Create(Neighborhood entity)
        {
            var neighborhood = _IRepositoryNeighborhood.FirstOrDefault(x => x.Id == entity.Id);
            if(neighborhood!=null)
            {
                throw new UserFriendlyException("NeighborHood already Exist");
            }
            else
            {
                return await _IRepositoryNeighborhood.InsertAsync(entity);
            }
        }
        //Delete a neighborhood from database 
        public void Delete(int id)
        {
            
            try
            {
                var neighborhood = _IRepositoryNeighborhood.Get(id);
                _IRepositoryNeighborhood.Delete(neighborhood);

            }
            catch (Exception)
            {

                throw new UserFriendlyException("Neighborhood is not exist");
            }
        }
        // get all neighborhoods in the table database 
        public IEnumerable<Neighborhood> getAllList()
        {

            var output = _IRepositoryNeighborhood.GetAll();
            if (output == null)
            {
                var defaultList = new Neighborhood();
                return (IEnumerable<Neighborhood>)defaultList;

            }
            else
                return output;
        }
        // return a neighborhood by the id 
        public Neighborhood getNeighborhoodById(int id)
        {
            try
            {
                return _IRepositoryNeighborhood.Get(id);
            }
            catch (Exception)
            {

                throw new UserFriendlyException("Neighborhood is not exist");
            }
            
        }
        // update neighborhood details 
        public void Update(Neighborhood entity)
        {
            _IRepositoryNeighborhood.Update(entity);
        }
    }
}
