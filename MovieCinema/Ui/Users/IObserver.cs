using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Users
{
    public interface IObserver
    {
        void Update(Event notification);
    }
}
