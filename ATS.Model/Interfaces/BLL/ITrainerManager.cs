using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1.Models;

namespace test1.Interfaces.BLL
{
    public interface ITrainerManager
    {
        bool Save(Trainer trainer);

        Trainer GetTrainerByCode(string code);

        Trainer GetById(int id);

    }
}
