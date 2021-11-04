using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carService
{
    class Program
    {
        static void Main(string[] args)
        {
            SKODAToyota skoda = new SKODAToyota();
            SKODAToyota toyota = new SKODAToyota();
            Employees employee = new Employees();
            Another another = new Another();
            Shop shop = new Shop();
            Console.WriteLine("Введите марку своей машины (Skoda,Toyota,другое");
            string name = Console.ReadLine().ToLower();
            while (!name.Equals("skoda") && !name.Equals("toyota") && !name.Equals("другое"))
            {
                Console.WriteLine("Повторите ввод");
                name = Console.ReadLine().ToLower();
            }
            if (name.Equals("skoda"))
            {
                Console.WriteLine("Введите возраст машины");
                int age = Convert.ToInt32(Console.ReadLine());
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Повторите ввод!");
                }
                if (age <= 20)
                {
                    Console.WriteLine("Мы сможем осуществить ремонт!");
                    skoda.RepairOnTheEngine();
                    skoda.RepairOfWheels();
                    skoda.RefuilingOfAirCond();
                    skoda.CarPaint();
                    employee.SkodaEmployee();
                }
                else if (age>=20&&age<0)
                {
                    Console.WriteLine("Пожалуйста, обратитесь в другой сервис!");
                }
            }
            else if (name.Equals("toyota"))
            {
                Console.WriteLine("Введите возраст машины");
                int age=Convert.ToInt32(Console.ReadLine());
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.WriteLine("Повторите ввод!");
                }
                if (age <= 20)
                {
                    Console.WriteLine("Мы сможем осуществить ремонт!");
                    toyota.RepairOnTheEngine();
                    toyota.RepairOfWheels();
                    toyota.RefuilingOfAirCond();
                    toyota.CarPaint();
                    employee.ToyotaEmployee();
                }
                else
                {
                    Console.WriteLine("Пожалуйста, обратитесь в другой сервис!");
                }
            }
            else if(name.Equals("другое"))
            {
                another.MTPLCard();
                another.VehicleInsp();
                another.PaymentOfFine();
                another.AutoWash();
                Console.WriteLine("Нужно ли Вам что-нибудь в магазине?да/нет");
                string answer = Console.ReadLine();
                while (!answer.Equals("да") && !answer.Equals("нет"))
                {
                    Console.WriteLine("Повторите ввод!");
                    answer = Console.ReadLine().ToLower();
                }
                if (answer.Equals("да"))
                {
                    shop.CarShop();
                    employee.ShopEmployee();
                }
                else if (answer.Equals("нет"))
                {
                    Console.WriteLine("Будем ждать Вас в следующий раз!");
                }

            }

        }
    }
}
