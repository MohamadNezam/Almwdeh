using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Almwdeh.Common;
using Almwdeh.Models;
namespace Almwdeh.Controllers
{
    public class StudentsController : Controller
    {
        private AlmawadehDbEntities db = new AlmawadehDbEntities();  
        // GET: Students
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CreateStudent()
        {
            int userAcceseID = MySession.Current.UserID;
            var student = db.StudentsTbls.Where(s => s.UserAccessIDs == userAcceseID).FirstOrDefault();
            if (student == null)
            {
                return View("CreateStudent");
            }
            return View("Index");
            
        }
       
        //public PartialViewResult profileStudent()
        //{
        //    int userAcceseID = MySession.Current.UserID;

        //    return PartialView(db.StudentsTbls.Where(s=>s.UserAccessIDs==userAcceseID).FirstOrDefault());
        //}

    }
}