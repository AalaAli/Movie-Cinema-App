using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.ShowTimes
{
    public interface IShowTimeBuilder
    {
        void SetMovie(int movieId);
        void SetHall(int hallId);
        void SetStartTime(DateTime startTime);
        void SetEndTime(DateTime endTime);
        void SetPrice();
        void SetLanguage(string language);

        ShowTime GetShowTime();
    }
}
