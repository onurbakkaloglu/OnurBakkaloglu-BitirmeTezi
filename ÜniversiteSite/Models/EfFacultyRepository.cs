using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public class EfFacultyRepository : IFacultyRepository
    {
        private Context context;
        public IQueryable<Faculty> Faculties => context.Faculties;
        public EfFacultyRepository(Context ctx)
        {
            context = ctx;
        }

        public void CreateFaculty(Faculty p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteFaculty(Faculty p)
        {
            context.Remove(p);
            context.SaveChanges();
        }

        public List<Faculty> GetFaculties()
        {
            var result = context.Faculties.ToList();
            return result;
        }

        public void SaveFaculty(Faculty p)
        {
            context.SaveChanges();
        }
    }
}
