using System;

namespace MovieCinema
{
    public class User
    {
        // هذه المتغيرات private (خاصة) داخل الكلاس
        int UserId;
        string UserName;
        string Password;
        string Email;
        string Phone;
        bool IsAdmin;

        public User(int id, string username, string email, string password, string phone, bool isAdmin)
        {
            UserId = id;
            UserName = username;
            Email = email;
            Password = password;
            Phone = phone;
            IsAdmin = isAdmin;
        }

        // هذه الدوال public (عامة) وهي التي ستستخدمينها في واجهة الفيلم
        public int GetUserId() => UserId;
        public string GetUserName() => UserName;
        public string GetPassword() => Password;
        public string GetEmail() => Email;
        public string GetPhone() => Phone;
        public bool GetIsAdmin() => IsAdmin;
    }
}