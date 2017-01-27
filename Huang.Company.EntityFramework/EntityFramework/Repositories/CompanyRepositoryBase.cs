using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace Huang.Company.EntityFramework.Repositories
{
    public abstract class CompanyRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<CompanyDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected CompanyRepositoryBase(IDbContextProvider<CompanyDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class CompanyRepositoryBase<TEntity> : CompanyRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected CompanyRepositoryBase(IDbContextProvider<CompanyDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
