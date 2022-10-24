using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Car
    {

        public string Model;//модель
        public int YearBird;
        public static float MaxSpeed = 320;
        public int run;

        public bool StartEngine;

        public vector_3 Position;

        public Car()
        {
            Position = new vector_3();
            Model = "Неизвестно";
            YearBird = 0000;
            run = 0;
            StartEngine = false;


        }

        public Car(string model, vector_3 pos)
        {
            Position = pos;
            Model = model;
            YearBird = DateTime.Today.Year;
            run = 0;
            StartEngine = false;

        }
        public void Start()
        {
            Console.WriteLine($"Машина {Model} Включилась");

            StartEngine = true;

        }
        public void off ()
        {
            Console.WriteLine($"Машина {Model} Выключилась");
            StartEngine = false;
        }
        
        public void Move(vector_3 vector)
        {
            if (!StartEngine)// (startEngine !=true) or (StartEngine == false)
                return;


            Position.X += vector.X;
            Position.Y += vector.Y;
            Position.Z += vector.Z;
            run++;

        }

        public string Getinfo() => $"Тачка {Model}. {YearBird} года выпуска. Двигатель {StartEngine}. Позиция = X: {Position.Y} X: {Position.Z} X:{Position.Z}";






    }
}
