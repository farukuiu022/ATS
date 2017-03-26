using System.Collections.Generic;
using System.Linq;
using test1.Models;
using ATS.Model.Context;

namespace test1.DAL
{
    public class InstitutionRepository
    {
        public ICollection<Institute> GetAll()
        {
            TrainingManagementDBContext db = new TrainingManagementDBContext();

            var instituteList = db.Institutes;

            return instituteList.ToList();

        }
    }
}