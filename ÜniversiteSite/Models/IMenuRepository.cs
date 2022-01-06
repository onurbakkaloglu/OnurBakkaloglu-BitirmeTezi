using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public interface IMenuRepository
    {
        IQueryable<Menu> Menus { get; }
        void SaveMenu(Menu p);
        void CreateMenu(Menu p);
        void DeleteMenu(Menu p);
        List<Menu> GetMenus();
    }
}
