using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genr
{
    public abstract class Genre:GenreComponent
    {
        public Genre(int GnId, string GnName) : base(GnId, GnName)
        {
        }
        public  void DisplayGenres() { }
    }
}
