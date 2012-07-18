using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using GolfStopp.Data;
using GolfStopp.Models;
using System.Threading;

namespace GolfStopp.Controllers
{
    public class ClubController : ApiController
    {
        // GET api/values
        public IEnumerable<object> Get()
        {
            using(GolfStoppRepository repository = new GolfStoppRepository())
            {
                return repository.GetClubs();
            }
        }

        // GET api/values/5
        public string Get(int id)
        {
            return null;
        }

        public ClubModelExtended GetClubExtended(string clubIdExtended)
        {
            Thread.Sleep(1000);
            using (GolfStoppRepository db = new GolfStoppRepository())
            {
                ClubModelExtended club = db.GetClubExtended(clubIdExtended);
                return club;
            }
        }
    }
}
