using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEX_2.Models
{
    public class EFCrashRepository : ICrashRepository
    {
        private CrashDBContext context { get; set; }

        public EFCrashRepository (CrashDBContext temp)
        {
            context = temp;
        }

        public IQueryable<Crash> Crashes => context.Crashes;
    }
}
