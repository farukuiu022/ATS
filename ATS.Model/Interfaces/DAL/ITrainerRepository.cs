using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test1.Models;

namespace test1.Interfaces.DAL
{
    public interface ITrainerRepository : IRepository<Trainer>
    {

        Trainer GetTrainerByCode(string code);



    }
}
