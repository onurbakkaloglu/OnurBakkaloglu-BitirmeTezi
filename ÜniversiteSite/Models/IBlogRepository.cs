using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public interface IBlogRepository
    {
        IQueryable<Blog> Blogs { get; }
        void SaveBlog(Blog p);
        void CreateBlog(Blog p);
        void DeleteBlog(Blog p);
        List<Blog> GetBlog();
    }
}
