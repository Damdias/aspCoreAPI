using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Contoso.Data
{
   public interface IDatabase
    {
        DbContext DbContext { get; }
        DbSet<T> GetDbSet<T>() where T : class;
    }
}
