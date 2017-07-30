using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Contoso.Data
{
    public class SqlDatabase : IDatabase
    {
        public SqlDatabase(SchoolContext context)
        {
            _context = context;
        }
        private readonly SchoolContext _context;
        public DbContext DbContext
        {
            get
            {
                return _context;
            }
        }

        public DbSet<T> GetDbSet<T>() where T : class
        {
            return _context.Set<T>();
        }
    }
}
