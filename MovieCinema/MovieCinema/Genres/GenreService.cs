using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genres
{
    internal class GenreService
    {
        /*        GetGenreTree()

        GetLeafGenres()

        IsLeafGenre(id)

        FindGenreInTree() ← يفيدكم في Search by Genre*/

        IRepository<Genre> _genreRepository;
        public GenreService(IRepository<Genre> repository) {
            _genreRepository = repository;
        }
        public void Add(Genre genre)
        {
            _genreRepository.Add(genre);
        }
        public void Update(Genre genre)
        { 
            _genreRepository.Update(genre); 
        }
        public void Delete(Genre genre)
        {
            _genreRepository.Delete(genre.GetGenreId());
        }



    }
}
