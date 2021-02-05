using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GamesCatalog.Models
{
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Development { get; set; }
        public int GenreID { get; set; }
        public virtual Genre Genre { get; set; }
    }
}
