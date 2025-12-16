using MovieCinema.SqlConectionSingleton;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Repositories
{
    internal class TicketRepository:IRepository<Ticket>
    {
        SqlConnectionSingleton conn;
        SqlConnection con;
        public TicketRepository(string connectionString)
        {
            this.conn = SqlConnectionSingleton.GetInstance();
            con = SqlConnectionSingleton.GetSingleConnetion();
            con.ConnectionString = connectionString;
        }

        void IRepository<Ticket>.Add(Ticket entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand("insert into Tickets values(@user_id,@showtime_id,@seat_id, @price, @booking_date, @is_paid); ", con);
            cmd.Parameters.AddWithValue("@user_id", entity.GetUserId());
            cmd.Parameters.AddWithValue("@showtime_id", entity.GetShowTimeId());
            cmd.Parameters.AddWithValue("@seat_id", entity.GetSeatId());
            cmd.Parameters.AddWithValue("@price", entity.GetPrice());
            cmd.Parameters.AddWithValue("@booking_date", entity.GetBookingDate());
            cmd.Parameters.AddWithValue("@is_paid", entity.GetIsPaid());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine("Seat Added Successfully");
        }
        void IRepository<Ticket>.Delete(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"DELETE FROM Tickets WHERE TicketId={id}", con);
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Ticket {id} was Deleted Successfully");
        }
        void IRepository<Ticket>.Update(Ticket entity)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());

            SqlCommand cmd = new SqlCommand($"UPDATE Tickets SET UserId= @user_id,ShowTimeId= @showtime_id, SeatId= @seat_id, Price= @price,BookingDate= @booking_date,IsPaid= @is_paid WHERE TicketId={entity.GetTicketId()}", con);
            cmd.Parameters.AddWithValue("@user_id", entity.GetUserId());
            cmd.Parameters.AddWithValue("@showtime_id", entity.GetShowTimeId());
            cmd.Parameters.AddWithValue("@seat_id", entity.GetSeatId());
            cmd.Parameters.AddWithValue("@price", entity.GetPrice());
            cmd.Parameters.AddWithValue("@booking_date", entity.GetBookingDate());
            cmd.Parameters.AddWithValue("@is_paid", entity.GetIsPaid());
            cmd.ExecuteNonQuery();
            con.Close();
            Console.WriteLine($"Hall {entity.GetTicketId()} was Updated Successfully");
        }
        IEnumerable<Ticket> IRepository<Ticket>.GetAll()
        {
                con.Open();
                Console.WriteLine(con.State.ToString());
                SqlCommand cmd = new SqlCommand("SELECT * FROM Tickets", con);
                SqlDataReader reader = cmd.ExecuteReader();
                List<Ticket> tickets = new List<Ticket>();
                while (reader.Read())
                 {
                   Ticket ticket = new Ticket();
                   tickets.Add(ticket.CreateTicket(reader.GetInt32(0), reader.GetInt32(1),reader.GetInt32(2), reader.GetInt32(3),reader.GetDecimal(4),reader.GetDateTime(5),reader.GetBoolean(6)));
                  }
                 con.Close();
                return tickets;
        }
        Ticket IRepository<Ticket>.GetById(int id)
        {
            con.Open();
            Console.WriteLine(con.State.ToString());
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Tickets WHERE TicketId={id}", con);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();

            Ticket ticket = new Ticket();
            ticket = ticket.CreateTicket(reader.GetInt32(0), reader.GetInt32(1), reader.GetInt32(2), reader.GetInt32(3), reader.GetDecimal(4), reader.GetDateTime(5), reader.GetBoolean(6));
            con.Close();
            return ticket;
        }
    }
}
