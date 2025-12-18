using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema
{
    public interface ITicketService {
         Ticket CreateTicket(int ticketId, int userId, int showTimeId, int seatId, decimal price, DateTime birthDate, bool isPaid);
         void PrintTicket();
    }
    public class Ticket : ITicketService
    {
        int TicketId;
        int UserId;
        int ShowTimeId;
        int SeatId;
        decimal Price;
        DateTime BookingDate;
        bool IsPaid;
        public Ticket CreateTicket(int ticketId, int userId, int showTimeId, int seatId, decimal price, DateTime birthDate, bool isPaid)
        {
            return new Ticket { 
                BookingDate = birthDate, IsPaid = isPaid, Price = price, SeatId = seatId, ShowTimeId = showTimeId, TicketId = ticketId, UserId = userId 
            };
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

    public class  TicketProxy : ITicketService
    {
       private readonly Ticket _RealTicket;
        public TicketProxy(Ticket RealTicket)
        {
            _RealTicket = RealTicket;
        }
        public  Ticket CreateTicket(int ticketId, int userId, int showTimeId, int seatId, decimal price, DateTime birthDate, bool isPaid)
        {
            if (price < 0) 
            {       
               throw new ArgumentException("Price cannot be negative");
            }
            Console.WriteLine("Proxy : Validating ticket creation request...");
            Console.WriteLine("Ticket created successfully:");
            return _RealTicket.CreateTicket( ticketId,  userId,  showTimeId,  seatId,  price,  birthDate,  isPaid);
        }
        public void PrintTicket() { 
            if(_RealTicket!= null) 
            {
                _RealTicket.PrintTicket();
            }
            else
            {
                Console.WriteLine("No ticket to print.");
            }
        }
    }

}
