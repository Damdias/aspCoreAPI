using Contoso.Domain.Entities;

namespace Contoso.Data
{
    public interface IStudentRepository : IRepository<Student>
    {
      
    }
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        public StudentRepository(IDatabase database) : base(database)
        {
        }
    }
}
