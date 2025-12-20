using MovieCinema.Genres;
using MovieCinema.Movies;
using MovieCinema.Users;
using MovieCinema.SqlConectionSingleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    public class UserRepository:IRepository<User>
    {
        SqlConnectionSingleton conn;
        SqlConnection con;
        public UserRepository(string connectionString)
        {
            this.conn = SqlConnectionSingleton.GetInstance();
            con = SqlConnectionSingleton.GetSingleConnetion();
            con.ConnectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here
        
        void IRepository<User>.Add(User entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand("insert into Users values(@u_name,@email,@password,@phone,@is_admin) ",con);
            cmd.Parameters.AddWithValue("@u_name",entity.GetUserName());
            cmd.Parameters.AddWithValue("@email",entity.GetEmail());
            cmd.Parameters.AddWithValue("@password", entity.GetPassword());
            cmd.Parameters.AddWithValue("@phone",entity.GetPhone());
            cmd.Parameters.AddWithValue("@is_admin", entity.GetIsAdmin());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("User Added Successfully");
        }
        void IRepository<User>.Delete(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"DELETE FROM Users WHERE UserId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"User {id} was Deleted Successfully");
           

        }
        void IRepository<User>.Update(User entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"UPDATE Users SET UserName = @u_name ,Email=@email, PasswordHash=@password, Phone=@phone,IsAdmin=is_admin WHERE UserId={entity.GetUserId()}", con);
            cmd.Parameters.AddWithValue("@u_name", entity.GetUserName());
            cmd.Parameters.AddWithValue("@email", entity.GetEmail());
            cmd.Parameters.AddWithValue("@password", entity.GetPassword());
            cmd.Parameters.AddWithValue("@phone", entity.GetPhone());
            cmd.Parameters.AddWithValue("@is_admin", entity.GetIsAdmin());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"User {entity.GetUserId()} was Updated Successfully");

        }
        IEnumerable<User> IRepository<User>.GetAll()
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<User> users = new List<User>();
            while (reader.Read())
            { 
                User user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4),reader.GetBoolean(5));
                users.Add(user);
            }
            con.Close();
            return users;
        }
        User IRepository<User>.GetById(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE UserId={id}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            User user = new User(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(4), reader.GetBoolean(5));
            con.Close();
            return user;
        }
        // In UserRepository.cs, FIX THIS METHOD:
        User IRepository<User>.GetByName(string name) // Actually gets by email
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            // FIXED: This was broken - wrong SQL syntax
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users WHERE Email = @email", con);
            cmd.Parameters.AddWithValue("@email", name);

            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                User user = new User(reader.GetInt32(0),reader.GetString(1),reader.GetString(2),reader.GetString(3),reader.GetString(4),reader.GetBoolean(5)
                );
                con.Close();
                return user;
            }
            else
            {
                con.Close();
                return null; // No user found
            }
        }

        List<User> IRepository<User>.GetByMovie(int movieId)
        {
            throw new NotImplementedException();
        }
        bool IRepository<User>.HasConflict(User entity)
        {
/*            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Users WHERE UserName=@user_name OR Email=@email", con);
            cmd.Parameters.AddWithValue("@user_name", entity.GetUserName());
            cmd.Parameters.AddWithValue("@email", entity.GetEmail());
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            return count > 0;*/
                throw new NotImplementedException();
        }
        List<GenreComponent> IRepository<User>.GetGenresByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
