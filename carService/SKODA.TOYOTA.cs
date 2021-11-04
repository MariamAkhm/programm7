using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace carService
{
    class SKODAToyota: CarBrend
    {
        private string engine;
        private string wheels;
        private string refuelingOfAirConditioners;
        private string painting;
        public string Engine
        {
            get
            {
                return engine;
            }
            private set { }
        }
        public string Wheels
        {
            get
            {
                return wheels;
            }
            private set { }
        }
        public string RefuelingOfAirConditioners
        {
            get
            {
                return refuelingOfAirConditioners;
            }
            private set { }
        }
        public string Painting
        {
            get
            {
                return painting;
            }
            private set { }
        }
        public void RepairOnTheEngine()
        {
            Console.WriteLine("Нужна ли замена/починка двигателя?да/нет");
            engine = Console.ReadLine().ToLower();
            while (!engine.Equals("да") && !engine.Equals("нет"))
            {
                Console.WriteLine("Повторите ввод!");
                engine = Console.ReadLine().ToLower();
            }
            if (engine.Equals("да"))
            {
                Console.WriteLine("Двигатель будет сделан!");
            }
            else if(engine.Equals("нет"))
            {
                Console.WriteLine(" ");
            }
        }
        public void RepairOfWheels()
        {
            Console.WriteLine("Нужна ли замена колес?да/нет");
            wheels = Console.ReadLine().ToLower();
            while (!wheels.Equals("да") && !wheels.Equals("нет"))
            {
                Console.WriteLine("Повторите ввод!");
                wheels = Console.ReadLine().ToLower();
            }
            if (wheels.Equals("да"))
            {
                Console.WriteLine("Колеса будут заменены, ожидайте!");
            }
            else if (wheels.Equals("нет"))
            {
                Console.WriteLine(" ");
            }
        }
        public void RefuilingOfAirCond ()
        {
            Console.WriteLine("Нужна ли замена кондиционера?да/нет");
            refuelingOfAirConditioners = Console.ReadLine().ToLower();
            while (!refuelingOfAirConditioners.Equals("да") && !refuelingOfAirConditioners.Equals("нет"))
            {
                Console.WriteLine("Повторите ввод!");
                refuelingOfAirConditioners = Console.ReadLine().ToLower();
            }
            if (refuelingOfAirConditioners.Equals("да"))
            {
                Console.WriteLine("Кондиционер будет заменен, ожидайте!");
            }
            else if(refuelingOfAirConditioners.Equals("нет"))
            {
                Console.WriteLine(" ");
            }
        }
        public void CarPaint()
        {
            Console.WriteLine("Нужна ли покраска авто?да/нет");
            painting = Console.ReadLine().ToLower();
            while (!painting.Equals("да") && !painting.Equals("нет"))
            {
                Console.WriteLine("Повторите ввод!");
                painting = Console.ReadLine().ToLower();
            }
            if (painting.Equals("да"))
            {
                Console.WriteLine("Машина будет покрашена, ожидайте!");
            }
            else if (refuelingOfAirConditioners.Equals("нет"))
            {
                Console.WriteLine(" ");
            }
        }
    }
}
   
