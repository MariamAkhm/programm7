using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace carService
{
    class SKODA : CarBrend
    {
        private bool engine;
        private bool wheels;
        private bool painting;
        private bool refuelingOfAirConditioners;
        private int age;
        public bool Engine
        {
            get
            {
                return engine;
            }
            private set { }
        }
        public bool Wheels
        {
            get
            {
                return wheels;
            }
            private set { }
        }
        public bool Painting
        {
            get
            {
                return painting;
            }
            private set { }
        }
        public bool RefuelingOfAirConditioners
        {
            get
            {
                return refuelingOfAirConditioners;
            }
            private set { }
        }
        public int Age
        {
            get
            {
                return age;
            }
            private set { }
        }
        public void RepairOnTheEngine(bool engine)
        {
            this.engine = engine;
            engine = true;
            if (engine)
            {
                Console.WriteLine("Двигатель сделан!");
            }
            else
            {
                Console.WriteLine("не выбрано");
            }
        }
        public void ReplacingTheWheels(bool wheels)
        {
            this.wheels = wheels;
            wheels = true;
            if (wheels)
            {
                Console.WriteLine("Колеса поменяны!");
            }
            else
            {
                Console.WriteLine("Не выбрано!");
            }
        }
        public void PaintingOfCar(bool painting)
        {
            this.painting = painting;
            painting = true;
            if (painting)
            {
                Console.WriteLine("Колеса поменяны!");
            }
            else
            {
                Console.WriteLine("Не выбрано!");
            }
        }
        public void RefuilingOfConditioners(bool refuilingOfAirConditioners)
        {
            this.refuelingOfAirConditioners = refuelingOfAirConditioners;
            refuelingOfAirConditioners = true;
            if (refuelingOfAirConditioners)
            {
                Console.WriteLine("Колеса поменяны!");
            }
            else
            {
                Console.WriteLine("Не выбрано!");
            }
        }
        public void AgeOfCar(int age)
        {
            this.age = age;
            if (age >= 20)
            {
                Console.WriteLine("Срочно пора сдавать машину на запчасти!");
            }
            else
            {
                Console.WriteLine("Ремонт будет реализован!");
            }
        }
        }
    }
