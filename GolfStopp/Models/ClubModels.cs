using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GolfStopp.Models
{
    public class ClubModel
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class ClubModelExtended : ClubModel
    {
        public double MapLat { get; set; }
        public double MapLng { get; set; }
        public IEnumerable<CourseModel> Courses { get; set; }
        public string GolfSEId { get; set; }
        public string Homepage { get; set; }
    }
}