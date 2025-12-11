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
            Ticket T1 =new Ticket();
            TicketProxy TP1=new TicketProxy(T1);
            T1=TP1.CreateTicket(1,101,1800,12,15.50,DateTime.Now,true);
            TP1.PrintTicket();

            Movie M1=new Movie(1,"Inception","A mind-bending thriller",148,"/path/to/poster.jpg",8.8f);
            M1.DisplayMovieInfo();
            Movie M2=M1.CloneMovie();
            M2.DisplayMovieInfo();
        }
    }
}
