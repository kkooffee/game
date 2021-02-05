using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCatalog.Models
{
    public class DBInitial
    {
        static public void Initial(DBContent content)
        {
            if (!content.Genres.Any())
            {
                content.Genres.AddRange(Genres().Select(c => c.Value));
                content.SaveChanges();
            }
            if (!content.Games.Any())
            {
                content.Games.AddRange(Games().Select(c => c.Value));
                content.SaveChanges();
            }
            

        }
        private static Dictionary<string, Genre> DiGenre;
        private static Dictionary<string,Genre> Genres()
        {
            if (DiGenre == null)
            {
                var list = new Genre[]
                {
                    new Genre { Name = "Экшен", Desc = "default" },
                    new Genre { Name = "Симулятор", Desc = "default" },
                    new Genre { Name = "Стратегия", Desc = "default" },
                    new Genre { Name = "Ролевая", Desc = "default" },
                    new Genre { Name = "Приключения", Desc = "default" },
                    new Genre { Name = "Квест", Desc = "default" },
                    new Genre { Name = "Шутер", Desc = "default" },

                };
                DiGenre = new Dictionary<string, Genre>();
                foreach (Genre el in list)
                {
                    DiGenre.Add(el.Name, el);
                }
            }
            return DiGenre;
        }

        private static Dictionary<string, Game> DiGame;
        public static Dictionary<string, Game> Games()
        {
            if (DiGame == null)
            {
                var list = new Game[]
                {
                    new Game { Name = "name1", Development = "development_1", Genre = DiGenre["Экшен"] },
                    new Game { Name = "name2", Development = "development_2", Genre = DiGenre["Симулятор"] },
                    new Game { Name = "name3", Development = "development_3", Genre = DiGenre["Стратегия"] },
                    new Game { Name = "name4", Development = "development_4", Genre = DiGenre["Ролевая"] },
                };
                DiGame = new Dictionary<string, Game>();
                foreach (Game el in list)
                    DiGame.Add(el.Name, el);
            }
            return DiGame;
        }
    }
}








