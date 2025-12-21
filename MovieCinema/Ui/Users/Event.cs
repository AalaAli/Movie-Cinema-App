using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Users
{
    public enum EventType
    {
        TicketBooked,
        TicketCancelled,
        ShowTimeAdded,
        MovieDownloaded
    }
    public class Event
    {
        public EventType Type { get; }
        public string Message { get; }
        public int? UserId { get; }
        public DateTime Date { get; }

        public Event(EventType type, string message, int? userId = null)
        {
            Type = type;
            Message = message;
            UserId = userId;
            Date = DateTime.Now;
        }
    }
}
