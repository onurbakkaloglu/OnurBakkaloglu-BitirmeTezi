using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public class EfMenuRepository : IMenuRepository
    {
        private Context context;
        public IQueryable<Menu> Menus => context.Menus;
        public EfMenuRepository(Context ctx)
        {
            context = ctx;
        }

        public void CreateMenu(Menu p)
        {
            context.Add(p);
            context.SaveChanges();
        }

        public void DeleteMenu(Menu p)
        {
            context.Remove(p);
            context.SaveChanges();
        }

        public List<Menu> GetMenus()
        {
            var result = context.Menus.ToList();
            return result;
        }

        public void SaveMenu(Menu p)
        {
            context.SaveChanges();
        }
    }
}
