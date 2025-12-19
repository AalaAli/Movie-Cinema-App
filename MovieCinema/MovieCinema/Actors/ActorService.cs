using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Actors
{
    public class ActorService
    {
        private readonly IRepository<Actor> _actorsRepository;
        public ActorService(IRepository<Actor> repository)
        {
            _actorsRepository = repository;
        }
        public void AddActor(Actor actor)
        {
            _actorsRepository.Add(actor);
        }
        public void DeleteActor(int id)
        {
            _actorsRepository.Delete(id);
        }
        public void UpdateActor(Actor actor)
        {
            _actorsRepository.Update(actor);
        }
        public IEnumerable<Actor> GetAllActors()
        {
            return _actorsRepository.GetAll();
        }
        public Actor GetActorById(int id)
        {
            return _actorsRepository.GetById(id);
        }
        public Actor GetActorByName(string name)
        {
            return _actorsRepository.GetByName(name);
        }
        }
    }
