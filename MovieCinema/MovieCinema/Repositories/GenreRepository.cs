using MovieCinema.Actors;
using MovieCinema.Genres;
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
        string connectionString;
        public GenreRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<GenreComponent>.Add(GenreComponent entity)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"DELETE FROM Genres WHERE GenreId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Genre {id} was Deleted Successfully");
        }
        void IRepository<GenreComponent>.Update(GenreComponent entity)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"UPDATE Genres SET GenreName = @genre_name WHERE GenreId={entity.GetGenreId()}", con);
            cmd.Parameters.AddWithValue("@genre_name", entity.GetGenreName());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Genre {entity.GetGenreId()} was Updated Successfully");
        }
        List<GenreComponent> IRepository<GenreComponent>.GetAll()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
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
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Genres WHERE GenreId={id}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            GenreComponent genre = new Genre(reader.GetInt32(0), reader.GetString(1));
            con.Close();
            return genre;
        }

    }
}
