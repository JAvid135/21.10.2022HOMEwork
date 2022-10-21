using _19._10._2022Homework.Models;
using Math;
using Service;
using System;

namespace _19._10._2022Homework
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Car car = new Car();
            //Console.WriteLine(car.Name);

            //Calculation calculation = new Calculation();
            //calculation.Calc();

            //Factorial factorial = new Factorial();
            //factorial.Faktorial();

            //Cat cat = new Cat();
            //cat.Name = "Məstan";
            //Console.WriteLine(cat.Name);
            //cat.Sound();
            //Bird bird = new Bird();
            //bird.Sound();
            //cat.Eat("Meat");

            //Student student = new Student();
            //student.Surname = "Eliyev";
            //Console.WriteLine(student.Surname);

            //Person person = new Person();

            //Car car = new Car();

            IUser user = new User();
            user.Login("qwerty@gmailcom","123456789");

        }
    }
}
