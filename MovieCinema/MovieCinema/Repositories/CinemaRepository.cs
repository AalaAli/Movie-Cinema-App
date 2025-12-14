using MovieCinema.Actors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    internal class CinemaRepository:IRepository<Cinema>
    {
        string connectionString;
        public CinemaRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<Cinema>.Add(Cinema entity)
        {
        }
        void IRepository<Cinema>.Delete(int id)
        {
        }
        void IRepository<Cinema>.Update(Cinema entity)
        {
        }
        List<Cinema> IRepository<Cinema>.GetAll()
        {
            return null;

        }
        Cinema IRepository<Cinema>.GetById(int id)
        {
            return null;
        }



    }
}
