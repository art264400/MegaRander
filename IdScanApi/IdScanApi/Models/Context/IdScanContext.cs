using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace IdScanApi.Models.Context
{
    public class IdScanContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public IdScanContext(DbContextOptions<IdScanContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }   
    }
}
