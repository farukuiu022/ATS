using ATS.Model.Context;
using System;
using ATS.Model.Context;
using test1.Interfaces.DAL;
using test1.Models;

namespace ATS.DAL.DAL
{
    public class TrainerRepository : BaseRepository<Trainer>, ITrainerRepository
    {
        public TrainingManagementDBContext Context
        {
            get
            {
                return base._db as TrainingManagementDBContext;
            }
        }
        public TrainerRepository() : base(new TrainingManagementDBContext())
        {
        }

        public TrainerRepository(DbContext db) : base(db)
        {

        }

        public void Dispose()
        {
            _db.Dispose();
        }

        public Trainer GetTrainerByCode(string code)
        {
            throw new NotImplementedException();
        }
    }
}