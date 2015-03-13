using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
    public class DefaultController : Controller
    {
        //
        // GET: /Default/

        public ActionResult Index()
        {
            ViewBag.Msg = "nihao";
            try
            {
                BLL.IBLL DB = new BLL.IBLL();

                MODEL.FindUsers u = DB.I_FindUsers.GetSingleModelBy(s => s.FuId == 2);
                ViewBag.Resault = u;
                ViewBag.Msg = u.FuName;
            }
            catch (Exception e)
            {
                ViewBag.Msg = e.Message;

                throw;
            }
            


            return View();
        }

    }
}
