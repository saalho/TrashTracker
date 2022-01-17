using System;
using System.Collections.Generic;
using System.Text;

namespace TrashTracker.Models
{
    //Not yet implemented!
    public class MonthlyData
    {
        public string Id { get; set; }
        public string MonthYear { get; set; }
        public float TotalMixed { get; set; }
        public float TotalMetal { set; get; }
        public float TotalGlass { set; get; }
        public float TotalPlastic { set; get; }
        public float TotalPaper { set; get; }
        public float TotalCardboard { set; get; }
    }
}
