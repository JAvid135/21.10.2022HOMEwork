using System;
using System.Collections.Generic;
using System.Text;

namespace _19._10._2022Homework.Models
{
    public class Animal
    {
        public string Name { get; set; }
        
        public virtual void Sound()
        {
            Console.WriteLine("Animal sound");
        }

        public void Eat()
        {
            Console.WriteLine("Animal eating");
        }

        public void Eat (string t)
        {
            Console.WriteLine(t);
        }
        
        public void Eat(string t, string w)
        {
            Console.WriteLine(t + " " + w);
        }

    }

}
