using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ÜniversiteSite.Models;

namespace ÜniversiteSite.IRepository
{
    public interface IBlogRepository
    {
        public Blog Save(Blog p);
        public Blog Update(Blog p);
        public Blog Get(int Id);
        public List<Blog> Gets();
        public string Delete(int Id);
            
    }
}
