using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public DateTime BlogDate { get; set; }
        public bool BlogStatus { get; set; }
    }
}
