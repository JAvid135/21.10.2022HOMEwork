using System;
using System.Collections.Generic;
using System.Text;

namespace _19._10._2022Homework.Models
{
    public interface IUser
    {
        void Login(string username, string password);
        string SendEmail(string email);

    }
}
