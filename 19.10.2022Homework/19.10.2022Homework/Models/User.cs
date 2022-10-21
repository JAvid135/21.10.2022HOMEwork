using System;
using System.Collections.Generic;
using System.Text;

namespace _19._10._2022Homework.Models
{
    public class User : IUser
    {
        public void Login(string username, string password)
        {
            Console.WriteLine("Oldu");
        }

        public string SendEmail(string email)
        {
            return "Gonderildi";
        }
    }
}
