using MovieCinema.Actors;
using MovieCinema.Genres;
using MovieCinema.Movies;
using MovieCinema.Repositories;
using MovieCinema.Seats;
using MovieCinema.ShowTimes;
using MovieCinema.Users;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace MovieCinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var flyweightFactory = new SeatFlyweightFactory();
            var seatFactory = new SeatFactory(flyweightFactory);

            Seat seat1 = seatFactory.CreateSeat(1, 2, 5, 10, "VIP", true);
            Seat seat2 = seatFactory.CreateSeat(2, 1, 5, 11, "VIP", true);
            Seat seat3 = seatFactory.CreateSeat(3, 1, 6, 1, "Standard", true);

            seat1.DisplaySeatInfo();
            seat2.DisplaySeatInfo();
            seat3.DisplaySeatInfo();
            string ConnectionString = "server=DESKTOP-V3MP8OJ\\SQL1919;database=MoviesDB;integrated security=True";
            IRepository<Seat> S =new SeatRepository(ConnectionString);
            S.Add(seat1);

        }
    }

}
  


