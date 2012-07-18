using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GolfStopp.Models;

namespace GolfStopp.Data
{
    public class GolfStoppRepository : IDisposable
    {
        golfstoppdbEntities db;

        public GolfStoppRepository()
        {
            db = new golfstoppdbEntities();
        }

        public IEnumerable<ClubModel> GetClubs()
        {
            List<ClubModel> cc = db.clubs.Select(c => new ClubModel() { Name = c.name, Id = c.id }).ToList();

            return cc;
        }

        public ClubModelExtended GetClubExtended(string clubId)
        {
            ClubModelExtended club = db.clubs.Where(c => c.id == clubId).Select(c => new ClubModelExtended() {Id = c.id, GolfSEId = c.golfseId, Name = c.name, MapLat = (double)c.mapLat, MapLng = (double)c.mapLng, Homepage = c.homepage }).ToList()[0];
            club.Courses = db.courses.Where(c => c.clubId == club.GolfSEId).Select(c => new CourseModel() { Name = c.name, Id = c.id, Par = (int)c.par, NumberOfHoles = (int)c.numberOfHoles }).ToList();
            return club;
        }

        public void Dispose()
        {
            if (db != null)
            {
                db.Dispose();
            }
        }
    }
}