using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema
{
    public interface ITicketService {
         Ticket CreateTicket(int TId, int UId, int STime, int StId, double Prc, DateTime BDate, bool IsPd);
         void PrintTicket();
    }
    public class Ticket : ITicketService
    {
        int TicketId;
        int UserId;
        int ShowTime;
        int SeatId;
        double Price;
        DateTime BookingDate;
        bool IsPaid;
        public Ticket CreateTicket(int TId, int UId, int STime, int StId, double Prc, DateTime BDate, bool IsPd)
        {
            return new Ticket { 
                BookingDate = BDate, IsPaid = IsPd, Price = Prc, SeatId = StId, ShowTime = STime, TicketId = TId, UserId = UId 
            };
        }
        public void PrintTicket() {
            Console.WriteLine($"TicketId: {TicketId} UserId: {UserId} ShowTime: {ShowTime} SeatId: {SeatId} Price: {Price} BookingDate: {BookingDate} IsPaid{IsPaid}");

        }

    }

    public class  TicketProxy : ITicketService
    {
       private readonly Ticket _RealTicket;
        public TicketProxy(Ticket RealTicket)
        {
            _RealTicket = RealTicket;
        }
        public  Ticket CreateTicket(int TId, int UId, int STime, int StId, double Prc, DateTime BDate, bool IsPd)
        {
            if (Prc < 0) 
            {       
               throw new ArgumentException("Price cannot be negative");
            }
            Console.WriteLine("Proxy : Validating ticket creation request...");
            Console.WriteLine("Ticket created successfully:");
            return _RealTicket.CreateTicket( TId,  UId,  STime,  StId,  Prc,  BDate,  IsPd);
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
