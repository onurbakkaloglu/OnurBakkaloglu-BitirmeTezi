using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public class Menu
    {
        [Key]
        public int Id { get; set; }
        public string MenuName { get; set; }
        public bool MenuStatus { get; set; }
    }
}
