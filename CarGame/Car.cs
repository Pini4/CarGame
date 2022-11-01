using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGame
{
    internal class Car
    {
        public string Model;
        public int YearBuild;
        public const float MaxSpeed = 320;
        public int Run;
        public int carkeys;
        public int fiction;
        public bool StartEngine;
        public bool CarKey;

        public Vector3 Position;

        public Car()
        {
            Position = new Vector3();
            Model = "Неизвестно";
            YearBuild = 0000;
            Run = 0;
            StartEngine = false;
            carkeys = 0110;
            fiction = 0000;
            CarKey = false;
        }
        public Car(string model, Vector3 pos)
        {
            Position = pos;
            Model = model;
            YearBuild = DateTime.Today.Year;
            Run = 0;
            StartEngine = false;
        }
       public void KeyIn()
        {
            Console.WriteLine("напишите 4x значный код ключа");
            fiction = Convert.ToInt32(Console.ReadLine());
            if (carkeys == fiction)
            {
                Console.WriteLine("Ключ вставлен");
                CarKey = true;
            }
            else
            {
                Console.WriteLine("Ключ не подходит");
            }

        }
        public void KeyOut()
        {
            CarKey = false;
            Console.WriteLine("Ключ был вынут");
        }
        public void Start()
        {
            if (!CarKey)
                return;
            Console.WriteLine($"Двигатель машины {Model} включился");
            StartEngine = true;
        }

        public void Off()
        {
            if (!CarKey)
                return;
            Console.WriteLine($"Двигатель машины  {Model} выключился");
            StartEngine = false;
        }

        public void Move(Vector3 vector)
        {
            if (!StartEngine)
                return;

            Position.X += vector.X;
            Position.Y += vector.Y;
            Position.Z += vector.Z;
            Run++;

            Console.WriteLine($"Машина {Model} передвинулась на X: {Position.X}, Y: {Position.Y}, Z: {Position.Z}");
        }

        public string GetInfo() => $"Тачка {Model}. {YearBuild} - год производства. Двигатель заведен. Позиция = X: {Position.X}, Y: {Position.Y}, Z: {Position.Z}. Пробег = {Run}";
    }
}
    

