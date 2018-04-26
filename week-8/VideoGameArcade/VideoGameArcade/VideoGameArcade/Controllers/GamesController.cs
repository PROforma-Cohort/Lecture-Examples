using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VideoGameArcade.DataContext;
using VideoGameArcade.Models;

namespace VideoGameArcade.Controllers
{
    public class GamesController : ApiController
    {
        // get all game
        public IEnumerable<Game> GetAllGames()
        {
            using (var db = new ArcadeContext())
            {
                return db.ArcadeGames.OrderBy(o => o.Title).ToList();
            }
        }

        //get one game
        public IHttpActionResult GetOneGame(int id)
        {
            using (var db = new ArcadeContext())
            {
                var game = db.ArcadeGames.SingleOrDefault(s => s.Id == id);
                if (game == null)
                {
                    return NotFound();
                } else
                {
                    return Ok(game);
                }
            }
        }
    }
}
