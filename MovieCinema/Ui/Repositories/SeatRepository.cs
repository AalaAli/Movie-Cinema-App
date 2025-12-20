using MovieCinema.Genres;
using MovieCinema.Movies;
using MovieCinema.Seats;
using MovieCinema.SqlConectionSingleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    internal class SeatRepository:IRepository<Seat>
    {
        SqlConnectionSingleton conn;
        SqlConnection con;
        public SeatRepository(string connectionString)
        {
            this.conn = SqlConnectionSingleton.GetInstance();
            con = SqlConnectionSingleton.GetSingleConnetion();
            con.ConnectionString = connectionString;
        }
        // Methods for CRUD operations on Actor entities would go here

        void IRepository<Seat>.Add(Seat entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
           SqlCommand cmd = new SqlCommand("insert into Seats values(@hall_id,@row_number,@seat_number, @seat_type, @is_available); ", con);
            cmd.Parameters.AddWithValue("@hall_id", entity.GetHallId());
            cmd.Parameters.AddWithValue("@row_number", entity.GetRowNumber());
            cmd.Parameters.AddWithValue("@seat_number", entity.GetSeatNumber());
            cmd.Parameters.AddWithValue("@seat_type", entity.GetSeatType());
            cmd.Parameters.AddWithValue("@is_available", entity.GetIsAvailable());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Seat Added Successfully");
        }
        void IRepository<Seat>.Delete(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"DELETE FROM Seat WHERE SeatId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Seat {id} was Deleted Successfully");
        }
        void IRepository<Seat>.Update(Seat entity)
        {

        }
        IEnumerable<Seat> IRepository<Seat>.GetAll()
        {
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("SELECT * FROM Seats", con);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Seat> seats = new List<Seat>();
            while (reader.Read())
            {
                SeatFactory seatFactory = new SeatFactory(new SeatFlyweightFactory());
                Seat seat = seatFactory.CreateSeat(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetBoolean(5));
                seats.Add(seat);
            }
            con.Close();
            return seats;
        }
        Seat IRepository<Seat>.GetById(int id)
        {
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Seats WHER SeatId={id}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            SeatFactory seatFactory = new SeatFactory(new SeatFlyweightFactory());
            Seat seat = seatFactory.CreateSeat(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetString(4), reader.GetBoolean(5));
            con.Close();
          return seat;
        }
        Seat IRepository<Seat>.GetByName(string name)
        {
            throw new NotImplementedException();
        }
        List<Seat> IRepository<Seat>.GetByMovie(int movieId)
        {
            throw new NotImplementedException();
        }
        bool IRepository<Seat>.HasConflict(Seat entity)
        {
            throw new NotImplementedException();
        }
        List<GenreComponent> IRepository<Seat>.GetGenresByMovieId(int movieId)
        {
            throw new NotImplementedException();
        }
    }
}
