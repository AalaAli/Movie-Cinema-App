using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Movies
{
    public class SearchByActorStrategy:SearchStrategy
    {
        public List<Movie>  SearchMovie(string actor, List<Movie> movies )
        {
            List<Movie> result = new List<Movie>();
            foreach(var movie in movies)
            {
                if (movie.HasActor(actor))
                {
                    result.Add(movie);
                }
            }
            return result;
        }
    }
}
