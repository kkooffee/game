using GamesCatalog.Interfaces;
using GamesCatalog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCatalog.Repository
{
    public class GamesRepo : IGames
    {
        private readonly DBContent dBContent;

        public GamesRepo(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }

        public IEnumerable<Game> AllGame => dBContent.Games;

        
        public Game CteateGame(Game game)
        {
            dBContent.Add(game);
            dBContent.SaveChanges();
            return game;
        }

        public void DeleteGame(int gameId)
        {
            dBContent.Remove(GetGame(gameId));
            dBContent.SaveChanges();
        }

        public Game GetGame(int gameId)
        {
            return dBContent.Games.Find(gameId);
        }

        public IEnumerable<Game> SellectGame(string genre)
        {
            return dBContent.Games.Where((game => game.Genre.Name== genre));
        }

        public Game UpdateGame(Game game)
        {
            dBContent.Entry(game).State = EntityState.Modified;
            dBContent.SaveChanges();
            return game;
        }

       
    }
}
