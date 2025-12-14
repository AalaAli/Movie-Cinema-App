using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genres
{
    public  class Genre:GenreComponent
    {
        public Genre(int GnId, string GnName) : base(GnId, GnName)
        {
        }
        public override void DisplayGenre()
        {
            Console.WriteLine($"GenreName: {GenreName}");
        }
        public override bool IsLeaf() => true;
    }
}
