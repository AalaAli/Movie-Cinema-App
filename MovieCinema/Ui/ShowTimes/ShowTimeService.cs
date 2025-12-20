using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieCinema.ShowTimes
{
    public class ShowTimeService
    {
        private readonly IRepository<ShowTime> _repository;

        public ShowTimeService(IRepository<ShowTime> repository)
        {
            _repository = repository;
        }

        public void AddShowTime(ShowTime _showTime, string showType)
        {
            IShowTimeBuilder showTimeBuilder;
            if (showType == "2D")
            {
                showTimeBuilder = new TwoDShowTimeBuilder();
            }
            else if (showType == "3D")
            {
                showTimeBuilder = new ThreeDShowTimeBuilder();
            }
            else
            {
                showTimeBuilder = new MaxShowTimeBuilder();

            }
            ShowTimeDirector showTimeDirector = new ShowTimeDirector(showTimeBuilder);
            ShowTime showTime = showTimeDirector.ConstructShowTime(0,_showTime.GetMovieId(),_showTime.GetHallId(),_showTime.GetStartTime(),_showTime.GetEndTime(),_showTime.GetLanguage());// Id will be set by the database




            _repository.Add(showTime);
        }
        public void DeleteShowTime(int showTimeId)
        {
            _repository.Delete(showTimeId);
        }
        public void UpdateShowTime(ShowTime showTime, string showType)
        {
            IShowTimeBuilder showTimeBuilder;
            if (showType == "2D")
            {
                showTimeBuilder = new TwoDShowTimeBuilder();
            }
            else if (showType == "3D")
            {
                showTimeBuilder = new ThreeDShowTimeBuilder();
            }
            else
            {
                showTimeBuilder = new MaxShowTimeBuilder();
                
            }
            MessageBox.Show("Updating ShowTime with ID: " + showTime.GetShowTimeId());
            ShowTimeDirector showTimeDirector = new ShowTimeDirector(showTimeBuilder);
            ShowTime _showTime = showTimeDirector.ConstructShowTime(showTime.GetShowTimeId(),showTime.GetMovieId(), showTime.GetHallId(), showTime.GetStartTime(), showTime.GetEndTime(), showTime.GetLanguage());//Id is important tp update existing record

            _repository.Update(_showTime);
        }
        public ShowTime GetShowTimeById(int showTimeId)
        {           
            return _repository.GetById(showTimeId);
        }

        public List<ShowTime> GetShowTimesByMovie(int movieId)
        {
            return _repository.GetByMovie(movieId);
        }
        public bool HasConflict(ShowTime showTime)
        {
            return _repository.HasConflict(showTime);
        }
    }
}
