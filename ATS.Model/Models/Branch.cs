using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test1.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int InstituteId { get; set; }
        public Institute institute { get; set; }
    }
}