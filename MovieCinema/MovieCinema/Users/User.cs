using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieCinema
{
    public class User
    {
        int UserId;
        string UserName;
        string Password;
        string Email;
        string Phone;

        public User(int id, string username, string password, string email,string phone)
        {
            UserId = id;
            UserName = username;
            Password = password;
            Email = email;
            Phone = phone;

        }
       public int GetUserId()=>UserId;
        public string GetUserName() => UserName;
        public string GetPassword() => Password;
        public string GetEmail() => Email;
        public string GetPhone()=>Phone;


    }
   
}
