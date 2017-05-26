using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pesaresi.Luca._5i.WebQuery.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Query(string input)
        {
            try
            {
                DAL dal = new DAL("Aziende.accdb");
                DataTable table = dal.Getdata(input);
                return View(table);
            }
            catch
            {
                return View("Index");
            }


        }
    }
}