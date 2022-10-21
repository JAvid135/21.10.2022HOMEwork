using System;
using System.Collections.Generic;
using System.Text;

namespace _19._10._2022Homework.Models
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }



    }

    public abstract class Person2
    {
        public abstract void Test1();
    }
}
