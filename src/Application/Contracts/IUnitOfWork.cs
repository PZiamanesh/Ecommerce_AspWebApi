using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Application.Contracts
{
    public interface IUnitOfWork
    {
        DbContext DbContext { get; }
        Task<int> Save(CancellationToken cancellationToken);
        IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity; 
    }
}
