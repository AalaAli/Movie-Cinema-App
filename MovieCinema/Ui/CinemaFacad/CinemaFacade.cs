
using MovieCinema.Repositories;
using MovieCinema.ShowTimes;
using MovieCinema.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MovieCinema.Tickets;
namespace MovieCinema.CinemaFacad
{
    public class CinemaFacade : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        private readonly IRepository<Seat> seatRepository;
        private readonly IRepository<Ticket> ticketRepository;
        private readonly IRepository<ShowTime> showTimeRepository;

        public CinemaFacade(
             IRepository<Seat> seatRepo,
            IRepository<Ticket> ticketRepo,
            IRepository<ShowTime> showTimeRepo)
        {
            seatRepository = seatRepo;
            ticketRepository = ticketRepo;
            showTimeRepository = showTimeRepo;
        }

        // ===== Observer Pattern =====
        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(Event notification)
        {
            foreach (var observer in observers)
            {
                observer.Update(notification);
            }
        }

        // ===== Facade Use Cases =====

        public void BookTicket(int seatId, int userId)
        {
            var seat = seatRepository.GetById(seatId);

            if (!seat.IsAvailable)
                throw new Exception("Seat is not available");

            seat.Reserve();
            seatRepository.Update(seat);

          //  var ticketProxy = new TicketServiceProxy(new Ticket());
            //var ticket =ticketProxy.CreateTicket();

          //  ticketRepository.Add(ticket);

            NotifyObservers(new Event(EventType.TicketBooked,$"Ticket booked for seat {seatId}",userId));
        }

        public void CancelTicket(int ticketId)
        {
            var ticket = ticketRepository.GetById(ticketId);
            var seat = seatRepository.GetById(ticket.GetSeatId());

            seat.CancelReservation();
            seatRepository.Update(seat);
            ticketRepository.Delete(ticketId);

            NotifyObservers(new Event(EventType.TicketCancelled,$"Ticket {ticketId} cancelled",ticket.GetUserId()
            )); 
        }

        public IEnumerable<Seat> GetAvailableSeats(int showTimeId)
        {
            // return seatRepository.GetAvailableSeatsByShowTime(showTimeId);//Add in seatRepository
            return null;
        }

        public void AddShowTime(ShowTime showTime)
        {
            showTimeRepository.Add(showTime);

            NotifyObservers(new Event(
                EventType.ShowTimeAdded,
                $"ShowTime added for movie {showTime.MovieId}"
            ));
        }
    }    
}
