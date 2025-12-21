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
            SqlCommand cmd= new SqlCommand();
            if (entity.GetParentId().GetValueOrDefault()==0)
            {
                cmd = new SqlCommand(" insert  into Genres (GenreName) values(@genre_name); ", con);
            }
            else
            {  cmd = new SqlCommand("insert  into Genres values(@genre_name,@parent_Id); ", con);
                cmd.Parameters.AddWithValue("@parent_Id", entity.GetParentId());
            }
            cmd.Parameters.AddWithValue("@genre_name", entity.GetGenreName());
            cmd.ExecuteNonQuery();
            con.Close();

        }
        void IRepository<GenreComponent>.Delete(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("DELETE FROM Genres WHERE GenreId=@genre_id", con);
            cmd.Parameters.AddWithValue("@genre_id", id);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        void IRepository<GenreComponent>.Update(GenreComponent entity)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand();
            if (entity.GetParentId().GetValueOrDefault() == 0)
            {
                cmd = new SqlCommand("update Genres set GenreName=@genre_name , ParentId= null where GenreId = @genreId ", con);
            }
            else
            {
                cmd = new SqlCommand("update Genres set GenreName = @genre_name, ParentId = @parent_id where GenreId = @genreId ", con);
                cmd.Parameters.AddWithValue("@parent_Id", entity.GetParentId()??0);
            }
            cmd.Parameters.AddWithValue("@genre_name", entity.GetGenreName());
            cmd.Parameters.AddWithValue("@genreId", entity.GetGenreId());
            cmd.ExecuteNonQuery();
            con.Close();
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
                GenreComponent genre = new Genre(reader.GetInt32(0), reader.GetString(1),reader.GetInt32(2));
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
            GenreComponent genre = new Genre(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
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
            GenreComponent genre = new Genre(reader.GetInt32(0), reader.GetString(1), reader.GetInt32(2));
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
