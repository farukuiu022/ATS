using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using test1.BLL;

namespace test1.UIUtility
{
    public class DropDownListProvider
    {
        private static InstitutionManager _institutionManager;

        static DropDownListProvider()
        {
            _institutionManager = new InstitutionManager();
        }

        public static List<SelectListItem> GetInstitutions()
        {
            var institutes = _institutionManager.GetAll();
            var instituteDropDownItems = new List<SelectListItem>();

            foreach (var institute in institutes)
            {
                var item = new SelectListItem() { Text = institute.Name, Value = institute.Id.ToString() };
                instituteDropDownItems.Add(item);
            }

            instituteDropDownItems.Insert(0, new SelectListItem() { Text = "Select...", Value = "" });

            return instituteDropDownItems;
        }
    }
}