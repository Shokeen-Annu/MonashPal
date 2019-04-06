using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MonPal.Models;

namespace MonPal.Controllers
{
    public class SearchEngineController : Controller
    {
        // GET: SearchEngine
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult SearchHome()
        {
            SearchModels searchObject = new SearchModels();
            fillFields(searchObject);
            return View("SearchHome", searchObject);
        }
        public void fillFields(SearchModels searchObject)
        {
            
            SelectListItem unit1 = new SelectListItem();
            unit1.Text = "FIT5148 - Big data";
            unit1.Value = "1";
            searchObject.unitList = new SelectList(new List<SelectListItem> { unit1 });

            SelectListItem timeComm1 = new SelectListItem();
            timeComm1.Text = "2 - 4 hrs";
            timeComm1.Value = "1";
            searchObject.timeCommList = new SelectList(new List<SelectListItem> { timeComm1 });

            SelectListItem activity1 = new SelectListItem();
            activity1.Text = "Singing";
            activity1.Value = "1";
            searchObject.activityList = new SelectList(new List<SelectListItem> { activity1 });
        }
    }
}