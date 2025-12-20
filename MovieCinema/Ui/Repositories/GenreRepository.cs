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
    internal class GenreRepository:IRepository<GenreComponent>
    {
        SqlConnectionSingleton conn;
        SqlConnection con;
        public GenreRepository(string connectionString)
        {
            this.conn = SqlConnectionSingleton.GetInstance();
            con = SqlConnectionSingleton.GetSingleConnetion();
            con.ConnectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<GenreComponent>.Add(GenreComponent entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand("insert into Genres values(@genre_name); ", con);
            cmd.Parameters.AddWithValue("@genre_name", entity.GetGenreName());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Genre Added Successfully");

        }
        void IRepository<GenreComponent>.Delete(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"DELETE FROM Genres WHERE GenreId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Genre {id} was Deleted Successfully");
        }
        void IRepository<GenreComponent>.Update(GenreComponent entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"UPDATE Genres SET GenreName = @genre_name WHERE GenreId={entity.GetGenreId()}", con);
            cmd.Parameters.AddWithValue("@genre_name", entity.GetGenreName());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Genre {entity.GetGenreId()} was Updated Successfully");
        }
        IEnumerable<GenreComponent> IRepository<GenreComponent>.GetAll()
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Genres", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<GenreComponent> genres = new List<GenreComponent>();
            while (reader.Read())
            {

                GenreComponent genre = new Genre(reader.GetInt32(0), reader.GetString(1));
                genres.Add(genre);
            }
            con.Close();
            return genres;
        }
        GenreComponent IRepository<GenreComponent>.GetById(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Genres WHERE GenreId={id}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            GenreComponent genre = new Genre(reader.GetInt32(0), reader.GetString(1));
            con.Close();
            return genre;
        }
        GenreComponent IRepository<GenreComponent>.GetByName(string name)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Genres WHERE GenreId={name}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            GenreComponent genre = new Genre(reader.GetInt32(0), reader.GetString(1));
            con.Close();
            return genre;
        }
        List<GenreComponent> IRepository<GenreComponent>.GetByMovie(int movieId)
        {
            throw new NotImplementedException();
        }
        bool IRepository<GenreComponent>.HasConflict(GenreComponent entity)
        {
            throw new NotImplementedException();
        }
        List<GenreComponent> IRepository<GenreComponent>.GetGenresByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
