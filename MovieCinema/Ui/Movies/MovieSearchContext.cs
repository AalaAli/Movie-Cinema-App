using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Movies
{
    public class MovieSearchContext
    {
        private SearchStrategy _strategy;
        public MovieSearchContext(SearchStrategy strategy)//set strategy
        {
            this._strategy = strategy;
        }
 
        public List<Movie> Search(string criterion, List<Movie> movies) {
            return this._strategy.SearchMovie(criterion,movies);
        }

    }
}
