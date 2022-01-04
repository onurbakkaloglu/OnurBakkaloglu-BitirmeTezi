using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ÜniversiteSite.Models
{
    public class Faculty
    {
        [Key]
        public int Id { get; set; }
        public string FacultyName { get; set; }
        public bool FacultyStatus { get; set; }
    }
}
