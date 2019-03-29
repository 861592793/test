using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;
using TestRedis.Common;
namespace TestRedis.Controllers
{
    public class TestController : Controller
    {
        //
        // GET: /Test/

        RedisHelper redisHelper = new RedisHelper();
        RedisHelper helper2 = new RedisHelper(2);

        public ActionResult Index()
        {
            return View(); 
        }

        public ActionResult Add()
        {
            helper2.StringSet("ww","rrrr");
           bool isSucess = redisHelper.StringSet("bb","123456");
           return Content(isSucess.ToString());
        }

        public ActionResult Get()
        {
           string value = redisHelper.StringGet("bb");
           return Content(value);
        }

        public ActionResult addLock()
        {
            redisHelper.addLock("lockkey", "1111");
            redisHelper.addLock("lockkey", "22222");
            //Thread.Sleep(5000);
            redisHelper.unLock("lockkey", "1111");
            redisHelper.unLock("lockkey", "22222");
            return Content("11111");
        
        }


    }
}
