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
        bool IsAdmin;

        public User(int id, string username, string email, string password,string phone, bool isAdmin)
        {
            UserId = id;
            UserName = username;
            Email = email;
            Password = password;
            Phone = phone;
            IsAdmin = isAdmin;
        }
        public int GetUserId()=>UserId;
        public string GetUserName() => UserName;
        public string GetPassword() => Password;
        public string GetEmail() => Email;
        public string GetPhone()=>Phone;
        public bool GetIsAdmin()=>IsAdmin;


    }
   
}
