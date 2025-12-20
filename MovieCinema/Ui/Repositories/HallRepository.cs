using MovieCinema.Actors;
using MovieCinema.Genres;
using MovieCinema.Movies;
using MovieCinema.SqlConectionSingleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MovieCinema.Repositories
{
    public class HallRepository:IRepository<Hall>
    {
        SqlConnectionSingleton conn;
        SqlConnection con;
        public HallRepository(string connectionString)
        {
            this.conn = SqlConnectionSingleton.GetInstance();
            con = SqlConnectionSingleton.GetSingleConnetion();
            con.ConnectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here
        void IRepository<Hall>.Add(Hall entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("insert into Halls values(@hall_name,@cinema_id,@seatcount); ", con);
            cmd.Parameters.AddWithValue("@hall_name", entity.GetHallName());
            cmd.Parameters.AddWithValue("@cinema_id", entity.GetCinemaId());
            cmd.Parameters.AddWithValue("@seatcount", entity.GetSeatCount());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Hall Added Successfully");
        }



        void IRepository<Hall>.Delete(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"DELETE FROM Halls WHERE HallId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Hall {id} was Deleted Successfully");
        }

        void IRepository<Hall>.Update(Hall entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"UPDATE Halls SET HallName = @hall_name ,CinemaId=@cinema_id, SeatCount=@seat_count WHERE HallId={entity.GetHallId()}", con);
            cmd.Parameters.AddWithValue("@hall_name", entity.GetHallName());
            cmd.Parameters.AddWithValue("@cinema_id", entity.GetCinemaId());
            cmd.Parameters.AddWithValue("@seat_count", entity.GetSeatCount());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Hall {entity.GetHallId()} was Updated Successfully");
        }
        IEnumerable<Hall> IRepository<Hall>.GetAll()
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Halls", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Hall> halls = new List<Hall>();
            while (reader.Read())
            {

                Hall hall = new Hall(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
                halls.Add(hall);
            }
            con.Close();
            return halls;
        }
        Hall IRepository<Hall>.GetById(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Halls WHERE HallId={id}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Hall hall = new Hall(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
            
            con.Close();
            return hall;
        }
        Hall IRepository<Hall>.GetByName(string name)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Halls WHERE HallName='{name}'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Hall hall = new Hall(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2), reader.GetInt32(3));
            con.Close();
            return hall;
        }
        List<Hall> IRepository<Hall>.GetByMovie(int movieId)
        {
            throw new NotImplementedException();
        }
        bool IRepository<Hall>.HasConflict(Hall entity)
        {
            throw new NotImplementedException();
        }
        List<GenreComponent> IRepository<Hall>.GetGenresByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
