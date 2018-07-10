using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TaawonMVC.EntityFramework.Repositories
{
    public abstract class TaawonMVCRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TaawonMVCDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TaawonMVCRepositoryBase(IDbContextProvider<TaawonMVCDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TaawonMVCRepositoryBase<TEntity> : TaawonMVCRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TaawonMVCRepositoryBase(IDbContextProvider<TaawonMVCDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
