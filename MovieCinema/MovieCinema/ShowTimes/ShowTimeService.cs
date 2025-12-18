using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.ShowTimes
{
    public class ShowTimeService
    {
        private readonly IRepository<ShowTime> _repository;

        public ShowTimeService(IRepository<ShowTime> repository)
        {
            _repository = repository;
        }

        public void CreateShowTime(int movieId,int hallId, DateTime start, DateTime end, decimal price,string language)
        {

            var showTime = new ShowTime
            {
                MovieId = movieId,
                HallId = hallId,
                StartTime = start,
                EndTime = end,
                Price = price,
                Language = language

            };

            if (_repository.HasConflict(showTime))
            {

                Console.WriteLine("conflict found ");
                return ;
            }

            _repository.Add(showTime);
        }

        public List<ShowTime> GetShowTimesByMovie(int movieId)
        {
            return _repository.GetByMovie(movieId);
        }
    }
}
