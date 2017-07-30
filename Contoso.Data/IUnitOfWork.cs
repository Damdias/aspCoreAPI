using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Contoso.Data
{
   public  interface IUnitOfWork
    {
        void Commit();
        Task CommitAsync();

    }
}
