using System.Threading.Tasks;

namespace Contoso.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDatabase _db;
        public UnitOfWork(IDatabase dbbase)
        {
            _db = dbbase;
        }
        public void Commit()
        {
            _db.DbContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _db.DbContext.SaveChangesAsync();
        }
    }
}
