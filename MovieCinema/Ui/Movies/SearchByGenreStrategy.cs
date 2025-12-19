using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Movies
{
    public class SearchByGenreStrategy:SearchStrategy
    {
        public List<Movie> SearchMovie(string Genre, List<Movie>movies)
        {
            List<Movie> result = new List<Movie>();
            foreach(var movie in movies)
            {
                if (movie.HasGenre(Genre))
                    result.Add(movie);
            }

            return result;
        }

    }
}
