using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace MvcApplication1.Controllers
{
    public class TestDataController : Controller
    {
        TestData dataBLL = new TestData();
        //
        // GET: /TestData/

        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ActionResult GetTemplateData(string number)
        {
            return Json(dataBLL.GetTemplateData(number));
        }

        public ActionResult addData(data dataPara)
        {
            return Json(dataBLL.addData(dataPara));
        }
        public ActionResult getData(string number, string attrKey)
        {
            return Json(dataBLL.getData(number,attrKey));
        }

        public ActionResult getAllData()
        {
            return Json(dataBLL.getAllData());
        
        }

        public ActionResult testTemp()
        {
            //return Content(Guid.NewGuid().ToString());
            //using (var db = new testdbEntities2())
            //{
            //    var lstData = db.spData().ToList();
            //    return Json(lstData, JsonRequestBehavior.AllowGet);
            //}

            //int? a = null;
            //int? b = 1;

            //StringBuilder sb = new StringBuilder();
            //sb.Append((a!=null?a.Value.ToString():"")+",");
            //sb.Append(b != null ? b.Value.ToString() : "" + ",");

            //return Content(sb.ToString());

            string str = "";

           //Task.Run(() => {
           //     Thread.Sleep(6000);
           //     str += "1111";
            
           // });
           // str += "222";
            return Content(str);

           
            
        }

        private async Task testAsync()
        {
            await Task.Run(() => {
                Thread.Sleep(3000);
            });
           
           
        }

    }
}
