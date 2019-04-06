using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MonPal.Models
{
    public class SearchModels
    {
        public int unitId { get; set; }
        public string unitName { get; set; }
        public SelectList unitList { get; set; }
        public int timeCommId { get; set; }
        public string timeCommName { get; set; }
        public SelectList timeCommList { get; set; }
        public int activityId { get; set; }
        public string activityName { get; set; }
        public SelectList activityList { get; set; }
    }
}