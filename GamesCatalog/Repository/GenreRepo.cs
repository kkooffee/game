using GamesCatalog.Interfaces;
using GamesCatalog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCatalog.Repository
{
    public class GenreRepo : IGenre
    {
        private readonly DBContent dBContent;

        public GenreRepo(DBContent dBContent)
        {
            this.dBContent = dBContent;
        }

        public IEnumerable<Genre> AllGenre => dBContent.Genres;

        public Genre CteateGenre(Genre genre)
        {
            dBContent.Add(genre);
            dBContent.SaveChanges();
            return genre;
        }

        public void DeleteGenre(int genreId)
        {
            dBContent.Remove(GetGenre(genreId));
            dBContent.SaveChanges();
        }

        public Genre GetGenre(int genreId)
        {
            return dBContent.Genres.Find(genreId);
        }

        public Genre UpdateGenre(Genre genre)
        {
            dBContent.Entry(genre).State = EntityState.Modified;
            dBContent.SaveChanges();
            return genre;
        }
    }
}
