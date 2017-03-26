using ATS.DAL.DAL;
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
    public class TrainerManager : ITrainerManager
    {
        private ITrainerRepository _trainerRepository;

        public TrainerManager()
        {
            _trainerRepository = new TrainerRepository();

        }

        public TrainerManager(ITrainerRepository trainerRepository, InstitutionManager institutionManager)
        {
            _trainerRepository = trainerRepository;

        }

        public bool Save(Trainer trainer)
        {
            if (trainer.Code == "")
            {
                throw new Exception("Code Not Provided while trying to insert a trainer!");
            }

            if (GetTrainerByCode(trainer.Code) != null)
            {
                throw new Exception("Trainer Code Already Exists!");
            }

            return _trainerRepository.Add(trainer);

        }

        public Trainer GetTrainerByCode(string code)
        {
            return _trainerRepository.GetTrainerByCode(code);
        }

        public Trainer GetById(int id)
        {
            return _trainerRepository.GetById(id);
        }


    }
}