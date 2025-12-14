using MovieCinema.Genres;
using MovieCinema.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MovieCinema.Repositories;
namespace MovieCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ticket T1 =new Ticket();
            TicketProxy TP1=new TicketProxy(T1);
            T1=TP1.CreateTicket(1,101,1800,12,15.50,DateTime.Now,true);
            TP1.PrintTicket();

            Movie M1=new Movie(1,"Inception","A mind-bending thriller",148,"/path/to/poster.jpg",8.8f);
            M1.DisplayMovieInfo();
            Movie M2=M1.CloneMovie();
            M2.DisplayMovieInfo();

            var G = new GenreComponent(1, "Action");
            var G1=new GenreGroup(4,"Popular Genre: ");
            G1.AddGenre(G);
            G1.AddGenre(new GenreComponent(2,"Comedy"));
            G1.AddGenre(new GenreComponent(3, "Drama"));
            G1.AddGenre(new GenreComponent(5, "Horror"));
            G.DisplayGenre();
            G1.DisplayGenre();*/
          
            string ConnectionString="server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";

            IRepository<User> UR = new UserRepository(ConnectionString);
            User u1 = new User(2, "Aala", "0000", "aala@gmail.com", "0915963905");
            // UR.Add(u1);
            //UR.Delete(2);
            // User u2 = new User(3, "Malak", "0000", "malak@gmail.com", "0915963905");
            //UR.Update(u2);
            // List<User> users = UR.GetAll();
            /*  foreach (User user in users)
              {
                  Console.WriteLine($"ID: {user.GetUserId()}, Name: {user.GetUserName()}, Email: {user.GetEmail()}, Phone: {user.GetPhone()}");
              }*/

            User u = UR.GetById(3);
            Console.WriteLine($"ID: {u.GetUserId()}, Name: {u.GetUserName()}, Email: {u.GetEmail()}, Phone: {u.GetPhone()}");

        }
    }
}
