using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genres
{
    internal class GenreService
    {
        private readonly IRepository<Genre> _repository;

        public GenreService(IRepository<Genre> repository)
        {
            _repository = repository;
        }
        public Genre GetOrCreate(string genreName)
        {
            var genre = _repository.GetByName(genreName);

            if (genre == null)
            {
                genre = new Genre (0,genreName);//id isn't used here because the db will assign it
                _repository.Add(genre);
            }

            return genre;
        }
        public IEnumerable<Genre> GetAllGenres()
        {
            return _repository.GetAll();
        }
        public void Add(Genre genre)
        {
            _repository.Add(genre);
        }
        public void UpdateGenre(Genre genre)
        {
            _repository.Update(genre);
        }
        public void DeleteGenre(int genreId)
        {
            _repository.Delete(genreId);
        }
    }
}
