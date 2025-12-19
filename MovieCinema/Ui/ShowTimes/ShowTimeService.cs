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
            IShowTimeBuilder showTimeBuilder;
            if (price==10m)
            {
                 showTimeBuilder = new TwoDShowTimeBuilder();
            }
            else if(price==15m)
            {
                 showTimeBuilder= new ThreeDShowTimeBuilder();
            }
            else
            {
                 showTimeBuilder = new MaxShowTimeBuilder();

            }
            ShowTimeDirector showTimeDirector = new ShowTimeDirector(showTimeBuilder);
            ShowTime showTime = showTimeDirector.ConstructShowTime(movieId,hallId,start,end,language);
 

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
