using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genres
{
    public class GenreComposite:GenreComponent
    {
        private List<GenreComponent> _genres = new List<GenreComponent>();
        public GenreComposite() { }
        public GenreComposite(int GnId, string GnName) : base(GnId,GnName)
        {
        }
        public void Add(GenreComponent genre)
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
        public override string GetGenreName()
        {
            return string.Join(" / ", _genres.Select(g => g.GetGenreName()));
        }
    }
}
