using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.ShowTimes
{
    public class ShowTimeDirector
    {
        private readonly IShowTimeBuilder _builder;

        public ShowTimeDirector(IShowTimeBuilder builder)
        {
            _builder = builder;
        }

        public ShowTime ConstructShowTime(int movieId, int hallId, DateTime startTime, DateTime endTime,string language)
        {
            _builder.SetMovie(movieId);
            _builder.SetHall(hallId);
            _builder.SetStartTime(startTime);
            _builder.SetEndTime(endTime);
            _builder.SetPrice();
            _builder.SetLanguage(language);

            return _builder.GetShowTime();
        }
    }
}
