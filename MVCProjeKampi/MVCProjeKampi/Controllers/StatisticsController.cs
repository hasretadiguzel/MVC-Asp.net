using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProjeKampi.Controllers
{
    public class StatisticsController : Controller
    {
        Context context = new Context();
        public ActionResult Index()
        {
            var result1 = context.Categories.Count().ToString();
            ViewBag.result1 = result1;

            var result2 = context.Headings.Count(h => h.CategoryID == 13).ToString();
            ViewBag.result2 = result2;

            var result3 = context.Writers.Where(w => w.WriterName.Contains("a") || w.WriterName.Contains("A")).Count();
            ViewBag.result3 = result3;

            var result4 = context.Categories.Where(u => u.CategoryID == context.Headings.GroupBy(x => x.CategoryID).OrderByDescending(x => x.Count())
              .Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.result4 = result4;

            var result5 = context.Categories.Where(c => c.CategoryStatus == true).Count() -
                context.Categories.Where(c => c.CategoryStatus == false).Count();
            ViewBag.result5 = result5;

            return View();
        }
    }
}