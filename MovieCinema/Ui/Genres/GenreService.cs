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
        private readonly IRepository<GenreComponent> _repository;

        public GenreService(IRepository<GenreComponent> repository)
        {
            _repository = repository;
        }
 /*       public GenreComponent GetOrCreate(string genreName,int parentId)
        {
            var genre = _repository.GetByName(genreName);

            if (genre == null)
            {
                genre = new Genre (0,genreName,parentId);//id isn't used here because the db will assign it
                _repository.Add(genre);
            }

            return genre;
        }*/
        public GenreComponent GetGenreById(int genreId)
        {
            return _repository.GetById(genreId);
        }
        public IEnumerable<GenreComponent> GetAllGenres()
        {
            return _repository.GetAll();
        }
        public void Add(GenreComponent genre)
        {
            _repository.Add(genre);
        }
        public void UpdateGenre(GenreComponent genre)
        {
            _repository.Update(genre);
        }
        public void DeleteGenre(int genreId)
        {
            _repository.Delete(genreId);
        }
    }
}
