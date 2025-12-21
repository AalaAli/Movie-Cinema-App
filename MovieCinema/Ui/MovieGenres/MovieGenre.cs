using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui
{
    public class MovieGenre
    {
        int MovieGenreId;
        int MovieId;
        int GenreId;

        public MovieGenre(int movieGenreId, int movieId, int genreId)
        {
            MovieGenreId = movieGenreId;
            MovieId = movieId;
            GenreId = genreId;
        }
        public int GetMovieGenreId() => MovieGenreId;
        public int GetMovieId() => MovieId;
        public int GetGenreId() => GenreId;
    }
   
}
