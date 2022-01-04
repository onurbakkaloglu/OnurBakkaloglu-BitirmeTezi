using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public class EfBlogRepository: IBlogRepository
    {
        private Context context;

        public IQueryable<Blog> Blogs => context.Blogs;

        public EfBlogRepository(Context ctx)
        {
            context = ctx;
        }    
        public void SaveBlog(Blog p)
        {
            context.SaveChanges();
        }

        public void CreateBlog(Blog p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteBlog(Blog p)
        {
            context.Remove(p);
            context.SaveChanges();
        }
    }
}
