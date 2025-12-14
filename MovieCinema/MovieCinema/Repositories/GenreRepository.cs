using MovieCinema.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    internal class GenreRepository:IRepository<GenreComponent>
    {
        string connectionString;
        public GenreRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<GenreComponent>.Add(GenreComponent entity)
        {
        }
        void IRepository<GenreComponent>.Delete(int id)
        {
        }
        void IRepository<GenreComponent>.Update(GenreComponent entity)
        {
        }
        List<GenreComponent> IRepository<GenreComponent>.GetAll()
        {
            return null;

        }
        GenreComponent IRepository<GenreComponent>.GetById(int id)
        {
            return null;
        }

    }
}
