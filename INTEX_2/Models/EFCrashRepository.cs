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

        public void SaveCrash(Crash c)
        {
            context.SaveChanges();
        }

        public void CreateCrash(Crash c)
        {
            context.Add(c);
            context.SaveChanges();
        }

        public void DeleteCrash(Crash c)
        {
            context.Remove(c);
            context.SaveChanges();
        }

        public IQueryable<Crash> Crashes => context.Crashes;
    }
}
