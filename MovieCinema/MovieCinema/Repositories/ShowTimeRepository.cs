using MovieCinema.SqlConectionSingleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    internal class ShowTimeRepository:IRepository<ShowTime>
    {
        SqlConnectionSingleton conn;
        SqlConnection con;
        public ShowTimeRepository(string connectionString)
        {
            this.conn = SqlConnectionSingleton.GetInstance();
            con = SqlConnectionSingleton.GetSingleConnetion();
            con.ConnectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<ShowTime>.Add(ShowTime entity)
        {
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("insert into ShowTimes values(@movie_id,@hall_id,@start_time,@end_time,@price,@language); ", con);
            cmd.Parameters.AddWithValue("@movie_id", entity.GetMovieId());
            cmd.Parameters.AddWithValue("@hall_id", entity.GetHallId());
            cmd.Parameters.AddWithValue("@start_time", entity.GetStartTime());
            cmd.Parameters.AddWithValue("@end_time", entity.GetEndTime());
            cmd.Parameters.AddWithValue("@price", entity.GetPrice());
            cmd.Parameters.AddWithValue("@language", entity.GetLanguage());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("ShowTime Added Successfully");
        }
        void IRepository<ShowTime>.Delete(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"DELETE FROM ShowTimes WHERE ShowTime={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"ShowTime {id} was Deleted Successfully");
        }
        void IRepository<ShowTime>.Update(ShowTime entity)
        {
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"UPDATE  ShowTimes SET MovieId= @movie_id,HallId= @hall_id,StartTime= @start_time,EndTime= @end_time,Price= @price,Language= @language WHERE ShowTime={entity.GetShowTimeId()}; ", con);
            cmd.Parameters.AddWithValue("@movie_id", entity.GetMovieId());
            cmd.Parameters.AddWithValue("@hall_id", entity.GetHallId());
            cmd.Parameters.AddWithValue("@start_time", entity.GetStartTime());
            cmd.Parameters.AddWithValue("@end_time", entity.GetEndTime());
            cmd.Parameters.AddWithValue("@price", entity.GetPrice());
            cmd.Parameters.AddWithValue("@language", entity.GetLanguage());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("ShowTime Added Successfully");
        }
        IEnumerable<ShowTime> IRepository<ShowTime>.GetAll()
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM ShowTimes", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<ShowTime> showtimes = new List<ShowTime>();
            while (reader.Read())
            {
                ShowTime showtime = new ShowTime(reader.GetInt32(0), reader.GetInt32(1),reader.GetInt32(2),reader.GetDateTime(3),reader.GetDateTime(4),reader.GetDecimal(5),reader.GetString(6));
                showtimes.Add(showtime);
            }
            con.Close();
            return showtimes;
        }
        ShowTime IRepository<ShowTime>.GetById(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM ShowTimes", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            ShowTime showtime = new ShowTime(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetDateTime(3), reader.GetDateTime(4), reader.GetDecimal(5), reader.GetString(6));
            con.Close();
            return showtime;
        }
    }
}
