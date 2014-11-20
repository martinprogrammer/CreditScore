using CreditScore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CreditScore.Controllers
{
    public class CreditScoreController : Controller
    {
        // GET: CreditScore
        public ActionResult Index()
        {
            var model = new List<CreditScoreTotalViewModel>();
            var d = new CreditScoreTotalsDataContext();

            var dt = d.CreditScoreTotals.Select(XmlSiteMapProvider => XmlSiteMapProvider.RequestDate.Date).Distinct();

            foreach (var dat in dt)
            {
                var res = d.CreditScoreTotals.Count(XmlSiteMapProvider => XmlSiteMapProvider.RequestDate == dat);
                var newvm = new CreditScoreTotalViewModel();
                newvm.NumberofScores = res;
                newvm.CreditCheckDate = dat;
                model.Add(newvm);
            }
            return View(model);
        }
    }
}