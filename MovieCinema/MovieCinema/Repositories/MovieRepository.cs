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
    internal class MovieRepository:IRepository<Movie>
    {
        SqlConnectionSingleton conn;
        SqlConnection con;
        public MovieRepository(string connectionString)
        {
            this.conn = SqlConnectionSingleton.GetInstance();
            con = SqlConnectionSingleton.GetSingleConnetion();
            con.ConnectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<Movie>.Add(Movie entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("insert into Movies values(@title,@description,@release_year,@duration,@posterpath,@rating,@genre_id); ", con);
            cmd.Parameters.AddWithValue("@title", entity.GetTitle());
            cmd.Parameters.AddWithValue("@description", entity.GetDescription());
            cmd.Parameters.AddWithValue("@release_year", entity.GetReleaseYear());
            cmd.Parameters.AddWithValue("@duration", entity.GetDuration());
            cmd.Parameters.AddWithValue("@posterpath", entity.GetPosterPath());
            cmd.Parameters.AddWithValue("@rating", entity.GetRating());
            cmd.Parameters.AddWithValue("@genre_id", entity.GetGenreId());

            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Movie Added Successfully");
        }
        void IRepository<Movie>.Delete(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"DELETE FROM Movies WHERE MovieId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Movie {id} was Deleted Successfully");
        }
        void IRepository<Movie>.Update(Movie entity)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"UPDATE  Movies SET Title= @title, Description= @description, ReleaseYear= @release_year, DurationMinutes = @duration,PosterPath = @posterpath, Rating = @rating, GenreId = @genre_id WHERE MovieId={entity.GetMovieId()}; ", con);
            cmd.Parameters.AddWithValue("@title", entity.GetTitle());
            cmd.Parameters.AddWithValue("@description", entity.GetDescription());
            cmd.Parameters.AddWithValue("@release_year", entity.GetReleaseYear());
            cmd.Parameters.AddWithValue("@duration", entity.GetDuration());
            cmd.Parameters.AddWithValue("@posterpath", entity.GetPosterPath());
            cmd.Parameters.AddWithValue("@rating", entity.GetRating());
            cmd.Parameters.AddWithValue("@genre_id", entity.GetGenreId());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Movie {entity.GetMovieId()} was Updated Successfully");

        }
        IEnumerable<Movie> IRepository<Movie>.GetAll()
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Movies", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Movie> movies = new List<Movie>();
            while (reader.Read())
            {

                Movie movie = new Movie(reader.GetInt32(0), reader.GetString(1),reader.GetString(2),reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5), reader.GetFloat(6),reader.GetInt32(7));
                movies.Add(movie);
            }
            con.Close();
            return movies;
        }
        Movie IRepository<Movie>.GetById(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Movies WHERE MovieId={id}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            Movie movie = new Movie(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3), reader.GetInt32(4), reader.GetString(5), reader.GetFloat(6), reader.GetInt32(7)); 
            con.Close();
            return movie;
        }

    }
}
