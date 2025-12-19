using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Users
{
    public class UserObserver : IObserver
    {
        public int UserId { get; }
        public string Name { get; }

        public UserObserver(int userId, string name)
        {
            UserId = userId;
            Name = name;
        }

        public void Update(Event notification)
        {

            if (notification.UserId != UserId)
                return;

            if (notification.Type == EventType.TicketBooked ||
                notification.Type == EventType.TicketCancelled)
            {
                Console.WriteLine($"User {Name}: {notification.Message}");
            }
        }
    }
}
