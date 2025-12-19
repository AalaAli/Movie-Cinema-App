using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Tickets
{

    public class Ticket 
    {
        int TicketId;
        int UserId;
        int ShowTimeId;
        int SeatId;
        decimal Price;
        DateTime BookingDate;
        bool IsPaid;

        public Ticket(int ticketId, int userId, int showTimeId, int seatId, decimal price, DateTime bookingDate, bool isPaid)
        {
            TicketId = ticketId;
            UserId = userId;
            ShowTimeId = showTimeId;
            SeatId = seatId;
            Price = price;
            BookingDate = bookingDate;
            IsPaid = isPaid;

        }
       
        public void PrintTicket() {
            Console.WriteLine($"TicketId: {TicketId} UserId: {UserId} ShowTime: {ShowTimeId} SeatId: {SeatId} Price: {Price} BookingDate: {BookingDate} IsPaid{IsPaid}");
        }
        public int GetTicketId() => TicketId;
        public int GetUserId() => UserId;
        public int GetShowTimeId() => ShowTimeId;
        public int GetSeatId() => SeatId;
        public decimal GetPrice() => Price;
        public DateTime GetBookingDate() => BookingDate;
        public bool GetIsPaid() => IsPaid;

    }


}
