using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GamesCatalog.Interfaces;
using GamesCatalog.Models;
using Microsoft.AspNetCore.Mvc;

namespace GamesCatalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly IGames dataGame;

        public GamesController(IGames dataGame)
        {
            this.dataGame = dataGame;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<Game> Get()
        {
            return dataGame.AllGame;
        }

        // GET api/genre/5
        [HttpGet("{ganre}")]
        public IEnumerable<Game> Get(string genre)
        {
            return dataGame.SellectGame(genre);
        }

        // POST api/games
        [HttpPost]
        public void Post([FromBody] Game game)
        {
            dataGame.CteateGame(game);
        }

        // PUT api/games/5
        [HttpPut]
        public void Put([FromBody] Game game)
        {
            dataGame.UpdateGame(game);
        }

        // DELETE api/games/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataGame.DeleteGame(id);
        }
    }
}
