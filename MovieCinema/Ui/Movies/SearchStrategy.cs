using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Movies
{
    public interface SearchStrategy
    {
         List<Movie> SearchMovie(string criterion, List<Movie> movies);
    }
}