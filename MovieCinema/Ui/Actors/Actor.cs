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
        public Actor()
        {

        }
        public Actor(int actorid,string actorname, string bio,DateTime birthdate)
        {
            ActorId = actorid;
            ActorName = actorname;
            Bio = bio;
            BirthDate= birthdate;

        }
       public int GetActorId() => ActorId;
        public string GetActorName() => ActorName;
        public string GetBio() => Bio;
        public DateTime GetBirthDate() => BirthDate;


    }
}
