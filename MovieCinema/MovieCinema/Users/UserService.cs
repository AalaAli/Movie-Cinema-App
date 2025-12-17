using MovieCinema.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema.Users
{
    internal class UserService
    {

        private readonly UserRepository _userRepository;

        public UserService(UserRepository repository)
        {
            _userRepository = repository;
        }

        public User Login(string username, string password)
        {

            var user = _userRepository.GetByUserName(username);
            if (user == null) throw new Exception("User doesn't exist");
            if (!user.GetPassword().Equals(password)) throw new Exception("Invalid Password");

            Console.WriteLine($"Welcome {user.GetUserName()}");
            return user;
        }

        public void Register(User user)
        {
            User u= _userRepository.GetByUserName(user.GetUserName());
            if (u == null)  
                 _userRepository.Add(user);
            else
                throw new Exception("User already exists");
        }
        public User GetUserById(int id)
        {
            User user= _userRepository.GetById(id);
            return user;
        }

        }


}
