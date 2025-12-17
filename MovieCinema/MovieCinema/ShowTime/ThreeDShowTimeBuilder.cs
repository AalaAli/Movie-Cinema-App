using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.ShowTime
{
    public class ThreeDShowTimeBuilder : IShowTimeBuilder
    {
        private readonly ShowTime _showTime;

        public ThreeDShowTimeBuilder()
        {
            _showTime = new ShowTime();
        }

        public void SetMovie(int movieId)
        {
            _showTime.MovieId = movieId;
        }

        public void SetHall(int hallId)
        {
            _showTime.HallId = hallId;
        }

        public void SetStartTime(DateTime startTime)
        {
            _showTime.StartTime = startTime;
        }

        public void SetEndTime(DateTime endTime)
        {
            _showTime.EndTime = endTime;
        }

        public void SetPrice()
        {
            _showTime.Price = 15;
        }

        public void SetLanguage()
        {
            _showTime.Language = "EN";
        }

        public ShowTime GetShowTime()
        {
            return _showTime;
        }
    }
}
