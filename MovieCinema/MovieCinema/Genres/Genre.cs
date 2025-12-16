using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genres
{
    public  class Genre:GenreComponent
    {
        public Genre(int GnId, string GnName,int ParentId) : base(GnId, GnName,ParentId)
        {
        }
        public override void DisplayGenre()
        {
            Console.WriteLine($"GenreName: {GenreName}");
        }
        public override bool IsLeaf() => true;
        public override int GetGenreId() => GenreId;
        public override string GetGenreName() => GenreName;
    }
}
