using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genres
{
    public class GenreGroup:GenreComponent
    {
        private List<GenreComponent> _genres = new List<GenreComponent>();
        public GenreGroup() { }
        public GenreGroup(int GnId, string GnName) : base(GnId,GnName)
        {
        }
        public void AddGenre(GenreComponent genre)
        {
            _genres.Add(genre);
        }
        public void RemoveGenre(GenreComponent genre)
        {
            _genres.Remove(genre);
        }
        public override void DisplayGenre()
        {
            Console.WriteLine("Genre Group:");
            foreach (var genre in _genres)
            {
                genre.DisplayGenre();
            }
        }
        public override bool IsLeaf() => false;
        public override int GetGenreId() => GenreId;
        public override string GetGenreName() => GenreName;
    }
}
