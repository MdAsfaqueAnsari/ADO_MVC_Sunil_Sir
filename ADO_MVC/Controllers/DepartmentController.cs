using ADO_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO_MVC.Controllers
{
    public class DepartmentController : Controller
    {
        // GET: Department
        private DepartmentDB department = new DepartmentDB();
        public ActionResult Index()
        {
            var dept = department.GetAllDepartment();
            return View(dept);
        }
    }
}