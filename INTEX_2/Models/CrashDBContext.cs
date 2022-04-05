using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX_2.Models
{
    public class CrashDBContext : DbContext
    {
        public CrashDBContext(DbContextOptions<CrashDBContext> options) : base(options)
        {

        }

        public DbSet<Crash> Crashes { get; set; }
    }
}
