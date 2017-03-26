using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test1.DAL;
using test1.Models;

namespace test1.BLL
{
    public class InstitutionManager
    {
        private InstitutionRepository _repository;
        private TrainerManager _trainerManager;
        public InstitutionManager()
        {
            _repository = new InstitutionRepository();
            _trainerManager = new TrainerManager();
        }

        public InstitutionManager(InstitutionRepository repository)
        {
            _repository = repository;
        }
        public ICollection<Institute> GetAll()
        {
            return _repository.GetAll();
        }
    }
}