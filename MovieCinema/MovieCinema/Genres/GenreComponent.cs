using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genres
{
    public abstract class GenreComponent
    {
        int GenreId;
       public string GenreName;
        public GenreComponent() { }
        public GenreComponent(int GnId, string GnName)
        {
            GenreId = GnId;
            GenreName = GnName;
        }
        public abstract void DisplayGenre();
        public abstract bool IsLeaf();

    }

    }
