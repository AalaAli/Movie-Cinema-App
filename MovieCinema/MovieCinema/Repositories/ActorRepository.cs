using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCinema.Actors;

namespace MovieCinema.Repositories
{
    internal class ActorRepository:IRepository<Actor>
    {
       string connectionString;
        public ActorRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here
       
        void IRepository<Actor>.Add(Actor entity)
        {
        }
        void IRepository<Actor>.Delete(int id)
        {
        }
        void IRepository<Actor>.Update(Actor entity)
        {
        }
        List<Actor> IRepository<Actor>.GetAll()
        {
            return null;

        }
        Actor IRepository<Actor>.GetById(int id)
        {
            return null;
        }



    }
}
