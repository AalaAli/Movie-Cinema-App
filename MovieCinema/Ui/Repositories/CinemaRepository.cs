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
    internal class CinemaRepository:IRepository<Cinema>
    {
        SqlConnectionSingleton conn;
        SqlConnection con;
        public CinemaRepository(string connectionString)
        {
            this.conn = SqlConnectionSingleton.GetInstance();
            con = SqlConnectionSingleton.GetSingleConnetion();
            con.ConnectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<Cinema>.Add(Cinema entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand("insert into Cinemas values(@cinema_name,@address); ", con);
            cmd.Parameters.AddWithValue("@cinema_name", entity.GetCinemaName());
            cmd.Parameters.AddWithValue("@address", entity.GetAddress());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Cinema Added Successfully");
        }
        void IRepository<Cinema>.Delete(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"DELETE FROM Cinemas WHERE CinemaId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Cinema {id} was Deleted Successfully");
        }
        void IRepository<Cinema>.Update(Cinema entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"UPDATE Cinemas SET CinemaName = @cinema_name ,Address=@address WHERE CinemaId={entity.GetCinemaId()}", con);
            cmd.Parameters.AddWithValue("@cinema_name", entity.GetCinemaName());
            cmd.Parameters.AddWithValue("@address", entity.GetAddress());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Cinema {entity.GetCinemaId()} was Updated Successfully");
        }
        IEnumerable<Cinema> IRepository<Cinema>.GetAll()
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Cinemas", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Cinema> cinemas = new List<Cinema>();
            while (reader.Read())
            {

                Cinema cinema = new Cinema(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                cinemas.Add(cinema);
            }
            con.Close();
            return cinemas;
        }
        Cinema IRepository<Cinema>.GetById(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Cinemas WHERE CinemaId={id}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Cinema cinema = new Cinema(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            con.Close();
            return cinema;
        }

        Cinema IRepository<Cinema>.GetByName(string name)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Cinemas WHERE CinemaName='{name}'", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Cinema cinema = new Cinema(reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
            con.Close();
            return cinema;
        }
        List<Cinema> IRepository<Cinema>.GetByMovie(int movieId)
        {
            throw new NotImplementedException();
        }
        bool IRepository<Cinema>.HasConflict(Cinema entity)
        {
            throw new NotImplementedException();
        }
        List<GenreComponent> IRepository<Cinema>.GetGenresByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }

    }
}
