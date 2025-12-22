using System;
using System.Windows.Forms; 

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

            if (notification.Type == EventType.MovieDownloaded)
            {
                var result = MessageBox.Show($"{notification.Message}\n\nDo you want to cancel the booking for this movie?",
                    "Download Manager", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Processing Cancellation...");
                }
            }
            else if (notification.Type == EventType.TicketBooked || notification.Type == EventType.TicketCancelled)
            {
                
                MessageBox.Show($"User {Name}: {notification.Message}", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}