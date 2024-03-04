using Application.Contracts;
using Domain.Entities.Base;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Presistence
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly EFcoreContext _context;

        public UnitOfWork(EFcoreContext context)
        {
            _context = context;
        }

        public DbContext DbContext => _context;

        public IGenericRepository<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            return new GenericRepository<TEntity>(_context);
        }

        public async Task<int> Save(CancellationToken cancellationToken)
        {
            return await _context.SaveChangesAsync();
        }
    }
}
