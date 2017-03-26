using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using test1.Context;
using test1.Models;

namespace test1
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            //Seed();
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }

        //public void Seed()
        //{
        //    TrainingManagementDBContext db = new TrainingManagementDBContext();
        //    var instituteList = new List<Institute>()
        //    {
        //        new Institute() {Id = 1, Name = "BITM"},
        //        new Institute() {Id = 2, Name = "TechnoBD"},
        //        new Institute() {Id = 3, Name = "BASIS"}
        //    };

        //    var branches = new List<Branch>()
        //   {
        //       new Branch() {Id = 1, InstituteId = 1, Name = "Dhaka"},
        //       new Branch() {Id = 2, InstituteId = 1, Name = "CTG"},
        //       new Branch() {Id = 3, InstituteId = 2, Name = "Dhaka HQ"}
        //   };

        //    db.Institutes.AddRange(instituteList);
        //    db.Branchs.AddRange(branches);

        //}
    }
}
