using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;

using MySqlDemo.Entity;

using MySqlDemo.Web.DbService;
using MySqlDemo.Web.Common;

namespace MySqlDemo.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dt = DbHelper.GetTable("select * from customers");
            var obj = dt.ToListModel<Customers>();

            return new JsonResult
            {
                Data = obj,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }

        public ActionResult Page()
        {
            var dt = DbHelper.GetTable("select * from customers limit 1,10");
            var obj = dt.ToListModel<Customers>();

            return new JsonResult
            {
                Data = obj,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }
    }
}