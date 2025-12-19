using MovieCinema.Repositories;
using MovieCinema.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Tickets
{
    // =====================
    // Ticket Service Interface
    // =====================
    public interface ITicketService
    {
        bool BookTicket(int userId, int seatId, decimal price);
        bool CancelTicket(int ticketId);
    }

    // =====================
    // Real Ticket Service
    // =====================
    public class TicketService
    {
        private readonly IRepository<Ticket> ticketRepository;
        private readonly IRepository<Seat> seatRepository;
        private readonly ISubject subject;

        public TicketService(IRepository<Ticket> ticketRepo,IRepository<Seat> seatRepo,ISubject subject)
        {
            ticketRepository = ticketRepo;
            seatRepository = seatRepo;
            this.subject = subject;
        }

        public bool BookTicket(int userId,int showTimeId, int seatId, decimal price)
        {
            var seat = seatRepository.GetById(seatId);
            seat.Reserve();
            seatRepository.Update(seat);
            var ticket =new Ticket(0,userId,showTimeId, seatId, price, DateTime.Now,true);// ticket id will be set by repository
            ticketRepository.Add(ticket);

            subject.NotifyObservers(new Event(EventType.TicketBooked,$"Ticket booked for seat {seatId}",userId));

            Console.WriteLine("Ticket booked successfully");
            return true;
        }

        public bool CancelTicket(int ticketId)
        {
            var ticket = ticketRepository.GetById(ticketId);
            var seat = seatRepository.GetById(ticket.GetSeatId());

            seat.CancelReservation();
            seatRepository.Update(seat);
            ticketRepository.Delete(ticketId);

            subject.NotifyObservers(new Event(EventType.TicketCancelled,$"Ticket {ticketId} cancelled", ticket.GetUserId()));

            Console.WriteLine("Ticket cancelled successfully");
            return true;
        }
    }


   
}
