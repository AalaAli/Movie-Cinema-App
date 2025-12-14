using MovieCinema.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCinema.Movies;

namespace MovieCinema.Repositories
{
    internal class MovieRepository:IRepository<Movie>
    {
        string connectionString;
        public MovieRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<Movie>.Add(Movie entity)
        {
        }
        void IRepository<Movie>.Delete(int id)
        {
        }
        void IRepository<Movie>.Update(Movie entity)
        {
        }
        List<Movie> IRepository<Movie>.GetAll()
        {
            return null;

        }
        Movie IRepository<Movie>.GetById(int id)
        {
            return null;
        }

    }
}
