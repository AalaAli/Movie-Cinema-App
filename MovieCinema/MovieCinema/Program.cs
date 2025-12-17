using MovieCinema.Actors;
using MovieCinema.Genres;
using MovieCinema.Movies;
using MovieCinema.Repositories;
using MovieCinema.ShowTime;
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
            IShowTimeBuilder builder = new ThreeDShowTimeBuilder();
            ShowTimeDirector director = new ShowTimeDirector(builder);

            ShowTime showTime = director.ConstructShowTime(
                movieId: 1,
                hallId: 2,
                startTime: DateTime.Now,
                endTime: DateTime.Now.AddHours(2)
            );

            showTime.DisplayInfo();

        }
    }

