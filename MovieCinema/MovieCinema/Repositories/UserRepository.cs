using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace MovieCinema.Repositories
{
    internal class UserRepository:IRepository<User>
    {
        string connectionString;
        public UserRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here
        
        void IRepository<User>.Add(User entity)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand("insert into Users values(@u_name,@email,@password,@phone) ",con);
            cmd.Parameters.AddWithValue("@u_name",entity.GetUserName());
            cmd.Parameters.AddWithValue("@email",entity.GetEmail());
            cmd.Parameters.AddWithValue("@password", entity.GetPassword());
            cmd.Parameters.AddWithValue("@phone",entity.GetPhone());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("User Added Successfully");
        }
        void IRepository<User>.Delete(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"DELETE FROM Users WHERE UserId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"User {id} was Deleted Successfully");
           

        }
        void IRepository<User>.Update(User entity)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"UPDATE Users SET UserName = @u_name ,Email=@email, PasswordHash=@password, Phone=@phone WHERE UserId={entity.GetUserId()}", con);
            cmd.Parameters.AddWithValue("@u_name", entity.GetUserName());
            cmd.Parameters.AddWithValue("@email", entity.GetEmail());
            cmd.Parameters.AddWithValue("@password", entity.GetPassword());
            cmd.Parameters.AddWithValue("@phone", entity.GetPhone());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"User {entity.GetUserId()} was Updated Successfully");

        }
        List<User> IRepository<User>.GetAll()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Users", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<User> users = new List<User>();
            while (reader.Read())
            {
                int userId = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string email = reader.GetString(2);
                string passwordHash = reader.GetString(3);
                string phone = reader.GetString(4);
                User user = new User(userId, userName, passwordHash, email, phone);
                users.Add(user);
            }
            con.Close();
            return users;
        }
        User IRepository<User>.GetById(int id)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = connectionString;
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Users WHERE UserId={id}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            int userId = reader.GetInt32(0);
                string userName = reader.GetString(1);
                string email = reader.GetString(2);
                string passwordHash = reader.GetString(3);
                string phone = reader.GetString(4);
                User user = new User(userId, userName, passwordHash, email, phone);
            
            con.Close();
            return user;
        }
    }
}
