using System.Linq;
using System.Threading.Tasks;

namespace Contoso.Data
{
    public interface IRepository<T>
    {
        IQueryable<T> GetAll();
        T Get(int id);
        Task<T> GetAsync(int id);
    }
       
}
