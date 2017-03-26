using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace test1.Models
{
    public class Trainer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Expartise { get; set; }
        public string Code { get; set; }
        public int YearofExparience { get; set; }
        public int InstituteId { get; set; }
        public Institute Institute { get; set; }
        public List<Trainee> Trainee { get; set; }
    }
}