using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Users
{
    public class AdminObserver : IObserver
    {
        public string AdminName { get; }

        public AdminObserver(string adminName)
        {
            AdminName = adminName;
        }

        public void Update(Event notification)
        {
            Console.WriteLine(
                $" Admin {AdminName} [{notification.Type}]: {notification.Message}"
            );
        }
    }
}
