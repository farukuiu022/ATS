using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using test1.Models;

namespace ATS.Model.Context
{
    public class TrainingManagementDBContext:DbContext
    {
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Institute> Institutes { get; set; }
        public DbSet<Branch> Branchs { get; set; }

    }
}