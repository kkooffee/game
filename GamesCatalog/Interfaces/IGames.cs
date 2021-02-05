using GamesCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCatalog.Interfaces
{
    public interface IGames
    {
        IEnumerable<Game> AllGame { get; }
        IEnumerable<Game> SellectGame(string genre);
        Game CteateGame(Game game);
        Game UpdateGame(Game game);
        Game GetGame(int gameId);
        void DeleteGame(int gameId);
    }
}
