using ATS.Model.Context;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using test1.Interfaces.BLL;
using test1.Models;
using test1.UIUtility;

namespace test1.Controllers
{
    public class TrainerController : Controller
    {
        private ITrainerManager _trainerManager;
        public TrainerController(ITrainerManager trainerManager)
        {
            _trainerManager = trainerManager;
        }
        TrainingManagementDBContext db = new TrainingManagementDBContext();
        [HttpGet]
        public ActionResult Create()
        {
            var instituteList = DropDownListProvider.GetInstitutions();

            ViewBag.InstituteList = instituteList;
            ModelState.AddModelError("Name", "Name must be provided");

            return View(new Trainer());
        }


        [HttpPost]
        public ActionResult Create(Trainer trainer)
        {



            if (ModelState.IsValid)
            {
                if (trainer != null)
                {
                    bool isSave = _trainerManager.Save(trainer);
                    if (isSave)
                    {
                        return View("Success");
                    }

                }
            }

            var instituteList = DropDownListProvider.GetInstitutions();

            ViewBag.InstituteList = instituteList;

            return View(trainer);
        }

        public string Edit()
        {
            return "Trainer Edited";
        }

        public string Search(string name)
        {
            string message = "Not Found!";
            if (!string.IsNullOrEmpty(name))
            {
                var trainer = db.Trainers.Where(c => c.Name == name).FirstOrDefault();

                if (trainer != null)
                {
                    message = "Trainer : " + trainer.Name;
                }
            }
            return message;
        }

        public JsonResult GetBranchesByInstitute(int? id)
        {
            List<Branch> branchList = db.Branchs.ToList();

            if (id != null)
            {
                branchList = branchList.Where(c => c.InstituteId == id).ToList();
            }

            return Json(branchList, JsonRequestBehavior.AllowGet);
        }



    }

}