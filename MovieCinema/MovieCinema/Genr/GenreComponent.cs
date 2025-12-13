using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Genr
{
    public class GenreComponent
    {
        int GenreId;
        string GenreName;

        public GenreComponent(int GnId, string GnName)
        {
            GenreId = GnId;
            GenreName = GnName;
        }
        public void DisplayGenre()
        {
            Console.WriteLine($"GenreName: {GenreName}");
        }
    }

    }
