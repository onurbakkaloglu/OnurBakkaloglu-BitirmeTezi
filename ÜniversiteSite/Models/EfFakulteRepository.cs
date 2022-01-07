using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public class EfFakulteRepository : IFakulteRepository
    {
        private Context context;
        public IQueryable<Fakulte> Fakultes => context.Fakultes;

        public EfFakulteRepository(Context ctx)
        {
            context = ctx;
        }

        public void CreateFakulte(Fakulte p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteFakulte(Fakulte p)
        {
            context.Remove(p);
            context.SaveChanges();
        }

        public List<Fakulte> GetFakultes()
        {
            var result = context.Fakultes.ToList();
            return result;
        }

        public void SaveFakulte(Fakulte p)
        {
            context.SaveChanges();
        }
    }
}
