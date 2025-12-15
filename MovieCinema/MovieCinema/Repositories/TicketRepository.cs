using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    internal class TicketRepository:IRepository<Ticket>
    {
        string connectionString;
        public TicketRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<Ticket>.Add(Ticket entity)
        {

        }
        void IRepository<Ticket>.Delete(int id)
        {
        }
        void IRepository<Ticket>.Update(Ticket entity)
        {
        }
        List<Ticket> IRepository<Ticket>.GetAll()
        {
            return null;

        }
        Ticket IRepository<Ticket>.GetById(int id)
        {
            return null;
        }
    }
}
