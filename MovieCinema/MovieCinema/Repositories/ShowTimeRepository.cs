using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    internal class ShowTimeRepository:IRepository<ShowTime>
    {
        string connectionString;
        public ShowTimeRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<ShowTime>.Add(ShowTime entity)
        {
        }
        void IRepository<ShowTime>.Delete(int id)
        {
        }
        void IRepository<ShowTime>.Update(ShowTime entity)
        {
        }
        IEnumerable<ShowTime> IRepository<ShowTime>.GetAll()
        {
            return null;

        }
        ShowTime IRepository<ShowTime>.GetById(int id)
        {
            return null;
        }
    }
}
