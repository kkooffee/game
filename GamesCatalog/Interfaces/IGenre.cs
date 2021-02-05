using GamesCatalog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCatalog.Interfaces
{
    public interface IGenre
    {
        IEnumerable<Genre> AllGenre { get; }
        Genre CteateGenre(Genre genre);
        Genre UpdateGenre(Genre genre);
        Genre GetGenre(int genreId);
        void DeleteGenre(int genreId);
    }
}
