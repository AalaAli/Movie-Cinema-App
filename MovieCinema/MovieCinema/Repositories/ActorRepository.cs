using MovieCinema.Actors;
using MovieCinema.SqlConectionSingleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    internal class ActorRepository:IRepository<Actor>
    {
        SqlConnectionSingleton conn;
        SqlConnection con;
        public ActorRepository(string connectionString)
        {
            this.conn = SqlConnectionSingleton.GetInstance();
            con = SqlConnectionSingleton.GetSingleConnetion();
            con.ConnectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here
       
        void IRepository<Actor>.Add(Actor entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand("insert into Actors values(@actor_name,@bio,@bdate); ", con);
            cmd.Parameters.AddWithValue("@actor_name", entity.GetActorName());
            cmd.Parameters.AddWithValue("@bio", entity.GetBio());
            cmd.Parameters.AddWithValue("@bdate", entity.GetBirthDate());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("aCTOR Added Successfully");
        }
        void IRepository<Actor>.Delete(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"DELETE FROM Actors WHERE ActorId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Actor {id} was Deleted Successfully");
        }
        void IRepository<Actor>.Update(Actor entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"UPDATE Actors SET ActorName = @actor_name ,Bio=@bio, BirthDate=@bdate WHERE ActorId={entity.GetActorId()}", con);
            cmd.Parameters.AddWithValue("@actor_name", entity.GetActorName());
            cmd.Parameters.AddWithValue("@bio", entity.GetBio());
            cmd.Parameters.AddWithValue("@bdate", entity.GetBirthDate());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"User {entity.GetActorId()} was Updated Successfully");
        }
        IEnumerable<Actor> IRepository<Actor>.GetAll()
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Actors", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Actor> actors = new List<Actor>();
            while (reader.Read())
            {
    
                Actor actor = new Actor(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
                actors.Add(actor);
            }
            con.Close();
            return actors;
        }
        Actor IRepository<Actor>.GetById(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Actors WHERE ActorId={id}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Actor actor = new Actor(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetDateTime(3));
            con.Close();
            return actor;
        }

    }
}
