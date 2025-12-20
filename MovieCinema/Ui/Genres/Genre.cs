using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genres
{
    public  class Genre:GenreComponent
    {
        public Genre(int genreId, string genreName, int ?parentId) : base(genreId, genreName, parentId)
        {
        }
        public override void DisplayGenre()
        {
            Console.WriteLine($"GenreName: {GenreName}");
        }
        public override bool IsLeaf() => true;
        public override int GetGenreId() => GenreId;
        public override string GetGenreName() => GenreName;
        public override int ?GetParentId() => ParentId;

    }
}
