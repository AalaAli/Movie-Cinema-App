using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genres
{
    public abstract class GenreComponent
    {
        internal int GenreId;

        internal string GenreName;

        public GenreComponent() { }
        public GenreComponent(int GnId, string GnName)
        {
            GenreId = GnId;
            GenreName = GnName;
        }
        public abstract void DisplayGenre();
        public abstract bool IsLeaf();
        public abstract int GetGenreId();
        public abstract string GetGenreName();

    }

    }
