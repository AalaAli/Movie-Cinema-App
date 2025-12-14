using MovieCinema.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    internal class HallRepository:IRepository<Hall>
    {

        string connectionString;
        public HallRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<Hall>.Add(Hall entity)
        {
        }
        void IRepository<Hall>.Delete(int id)
        {
        }
        void IRepository<Hall>.Update(Hall entity)
        {
        }
        List<Hall> IRepository<Hall>.GetAll()
        {
            return null;

        }
        Hall IRepository<Hall>.GetById(int id)
        {
            return null;
        }

    }
}
