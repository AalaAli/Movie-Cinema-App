using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Actors
{
    public class Actor
    {
        int ActorId;
       public string ActorName;
        string Bio;
        DateTime BirthDate;
        Actor()
        {

        }
        Actor(int actorid,string actorname, string bio,DateTime birthdate)
        {
            ActorId = actorid;
            ActorName = actorname;
            Bio = bio;
            BirthDate= birthdate;

        }

    }
}
