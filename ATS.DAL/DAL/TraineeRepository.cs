using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test1.Context;
using test1.DAL.Base;
using test1.Interfaces.DAL;
using test1.Models;

namespace test1.DAL
{
    public class TraineeRepository : BaseRepository<Trainee>, ITraineeRepository, IDisposable
    {
        public TrainingManagementDBContext Context
        {
            get
            {
                return base._db as TrainingManagementDBContext;

            }
        }

        public TraineeRepository() : base(new TrainingManagementDBContext())
        {
        }

        public void Dispose()
        {
            _db.Dispose();
        }

       
    }
}