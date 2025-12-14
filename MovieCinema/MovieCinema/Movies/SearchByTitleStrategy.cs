using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Movies
{
    public class SearchByTitleStrategy:SearchStrategy
    {
        public List<Movie> SearchMovie(string title,List<Movie> movies) {
            List<Movie> result= new List<Movie>();
            foreach (var movie in movies )
            {
                if (movie.Title.Equals(title))
                {
                    result.Add(movie);
                }
            }
            return result;
        }
    }
}
