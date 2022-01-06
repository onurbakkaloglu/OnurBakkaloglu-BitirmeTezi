using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public interface IFacultyRepository
    {
        IQueryable<Faculty> Faculties { get; }
        void SaveFaculty(Faculty p);
        void CreateFaculty(Faculty p);
        void DeleteFaculty(Faculty p);
        List<Faculty> GetFaculties();
    }
}
