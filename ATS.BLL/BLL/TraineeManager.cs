using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test1.DAL;
using test1.Interfaces.BLL;
using test1.Interfaces.DAL;
using test1.Models;

namespace test1.BLL
{
    public class TraineeManager : ITraineeManager
    {
        private ITraineeRepository _repository;

        public TraineeManager()
        {
            _repository = new TraineeRepository();
        }
        public bool Add(Trainee entity)
        {
            return _repository.Add(entity);
        }

        public bool Update(Trainee entity)
        {
            return _repository.Update(entity);
        }

        public bool Remove(Trainee entity)
        {
            return _repository.Remove(entity);
        }

        public Trainee GetById(int? id)
        {
            if (id == null)
            {
                return null;
            }

            return _repository.GetById((int)id);
        }

        public ICollection<Trainee> GetAll()
        {
            return _repository.GetAll();
        }
    }
}