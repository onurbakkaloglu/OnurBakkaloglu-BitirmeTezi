using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public interface IFakulteRepository
    {
        IQueryable<Fakulte> Fakultes { get; }
        void SaveFakulte(Fakulte p);
        void CreateFakulte(Fakulte p);
        void DeleteFakulte(Fakulte p);
        List<Fakulte> GetFakultes();
    }
}
