using MovieCinema.Genres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    internal class SeatRepository:IRepository<Seat>
    {

        string connectionString;
        public SeatRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<Seat>.Add(Seat entity)
        {
        }
        void IRepository<Seat>.Delete(int id)
        {
        }
        void IRepository<Seat>.Update(Seat entity)
        {
        }
        List<Seat> IRepository<Seat>.GetAll()
        {
            return null;

        }
        Seat IRepository<Seat>.GetById(int id)
        {
            return null;
        }

    }
}
