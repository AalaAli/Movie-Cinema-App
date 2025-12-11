using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            T1=new Ticket();
            TP1=new TicketProxy(T1);
        }
    }
}
