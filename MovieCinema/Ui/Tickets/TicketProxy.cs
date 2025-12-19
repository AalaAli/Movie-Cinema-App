using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Tickets
{    // =====================
    // Ticket Service Proxy (Validation)
    // =====================
    public class TicketServiceProxy : ITicketService
    {
        private readonly ITicketService realService;
        private readonly IRepository<Seat> seatRepository;

        public TicketServiceProxy(ITicketService realService, IRepository<Seat> seatRepo)
        {
            this.realService = realService;
            seatRepository = seatRepo;
        }

        public bool BookTicket(int userId, int seatId, decimal price)
        {
            if (price <= 0)
            {
                Console.WriteLine("Ticket price must be greater than zero");
                return false;
            }

            var seat = seatRepository.GetById(seatId);

            if (!seat.IsAvailable)
            {
                Console.WriteLine("Seat is not available");
                return false;
            }

            return realService.BookTicket(userId, seatId, price);
        }

        public bool CancelTicket(int ticketId)
        {
            if (ticketId <= 0)
            {
                Console.WriteLine("Invalid ticket id");
                return false;
            }

            return realService.CancelTicket(ticketId);
        }
    }
}
