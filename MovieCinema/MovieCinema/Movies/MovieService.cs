using MovieCinema.Genres;
using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Movies
{
    public class MovieService
    {
        IRepository<Movie> _movieRepository;
        public MovieService(MovieRepository repository)
        {
            _movieRepository = repository;
        }
        public bool ValidateMovie(Movie movie)
        {
            if(movie == null) return false;
            if (movie.GetRating() < 0 || movie.GetRating() > 5) return false;
            return true;
        }


        public void Add(Movie movie)
        {
            if (!ValidateMovie(movie))
            {
                throw new Exception("Object is Null or rating out of bounds");
            }
                _movieRepository.Add(movie);
        }
        public void Update(Movie movie)
        {
            if (!ValidateMovie(movie))
            {
                throw new Exception("Object is Null or rating out of bounds");
            }
            _movieRepository.Update(movie);
        }
        public void Delete(Movie movie)
        {
            //Check Showtime
            _movieRepository.Delete(movie.GetMovieId());
        }
        public Movie CloneMovie(int movieId)
        {
            var movie = _movieRepository.GetById(movieId);
            return movie.Clone();
        }
        public List<Movie> Search(SearchStrategy strategy, string query)
        {
            IEnumerable<Movie> allMovies = _movieRepository.GetAll();
            return strategy.SearchMovie(query, allMovies.ToList());
        }
        public void RateMovie(int movieId, decimal rating)
        {
            var movie =_movieRepository.GetById(movieId);
            if(ValidateMovie(movie))
            {
                throw new Exception("Object is Null or rating out of bounds");
            }
            decimal TotalRating = movie.GetRating();
            TotalRating+= (TotalRating+rating)/ 2;

            _movieRepository.Update(movie);
        }

    }
}
