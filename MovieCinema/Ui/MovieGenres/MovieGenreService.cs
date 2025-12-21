using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui.MovieGenres
{
    public class MovieGenreService
    {
        IRepository<MovieGenre> _movieGenreRepository;
        public MovieGenreService(IRepository<MovieGenre> movieGenreRepository)
        {
            _movieGenreRepository = movieGenreRepository;
        }
        public void Add(MovieGenre movieGenre)
        {
            _movieGenreRepository.Add(movieGenre);
        }
        public void Delete(int id)
        {
            _movieGenreRepository.Delete(id);
        }
        public void Update(MovieGenre movieGenre)
        {
            _movieGenreRepository.Update(movieGenre);
        }
    }
}
