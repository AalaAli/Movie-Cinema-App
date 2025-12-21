using MovieCinema.Genres;
using MovieCinema.Repositories;
using MovieCinema.SqlConectionSingleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ui.Repositories
{
    public class MovieGenreRepository:IRepository<MovieGenre>
    {
        SqlConnectionSingleton conn;
        SqlConnection con;
        public MovieGenreRepository(string connectionString)
        {
            this.conn = SqlConnectionSingleton.GetInstance();
            con = SqlConnectionSingleton.GetSingleConnetion();
            con.ConnectionString = connectionString;
        }
         void IRepository<MovieGenre>.Add(MovieGenre entity)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into MovieGenres values(@movie_id,@genre_id); ", con);
            cmd.Parameters.AddWithValue("@movie_id", entity.GetMovieId());
            cmd.Parameters.AddWithValue("@genre_id", entity.GetGenreId());
            cmd.ExecuteNonQuery();
            con.Close();

        }
         void IRepository<MovieGenre>.Delete(int id)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand($"DELETE FROM MovieGenres WHERE MovieGenreId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
         void IRepository<MovieGenre>.Update(MovieGenre entity)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update MovieGenres set MovieId=@movie_id, GenreId=@genre_id where MovieGenreId=@movie_genre_id; ", con);
            cmd.Parameters.AddWithValue("@movie_genre_id", entity.GetMovieGenreId());
            cmd.Parameters.AddWithValue("@movie_id", entity.GetMovieId());
            cmd.Parameters.AddWithValue("@genre_id", entity.GetGenreId());
            cmd.ExecuteNonQuery();
            con.Close();

        }
         IEnumerable<MovieGenre> IRepository<MovieGenre>.GetAll()
        {
            throw new NotImplementedException();
        }
         MovieGenre IRepository<MovieGenre>.GetById(int id)
        {
            throw new NotImplementedException();
        }
        List<MovieGenre>IRepository<MovieGenre>. GetByMovie(int movieId)
        {
            throw new NotImplementedException();
        }
        List<GenreComponent> IRepository<MovieGenre>.GetGenresByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }
        bool IRepository<MovieGenre>.HasConflict(MovieGenre entity)
        {
            throw new NotImplementedException();
        }
        MovieGenre IRepository<MovieGenre>.GetByName(string name)
        {
            throw new NotImplementedException();
        }


    }
}
