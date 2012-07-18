using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfStopp.Models
{
    public class CourseModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Par { get; set; }
        public int NumberOfHoles { get; set; }
    }
}