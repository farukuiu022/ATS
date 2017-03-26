using System.Collections.Generic;

namespace test1.Models
{
    public class Institute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Trainer>  Trainers { get; set; }
        public List<Branch> Branchs { get; set; }
    }
}