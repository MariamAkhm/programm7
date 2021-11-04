using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carService
{
    class Employees
    {
        public void SkodaEmployee()
        {
            string name = ("Борис");
            string brand = ("Skoda");
            Console.WriteLine("Вашей машиной займется:" + name,brand);
        }
        public void ToyotaEmployee()
        {
            string name = ("Михаил");
            string brand = ("Toyota");
            Console.WriteLine("Вашей машиной займется:"+name, brand);
        }
        public void ShopEmployee()
        {   
            string name = ("Марина");
            string brand = ("Работник магазина");
            Console.WriteLine("Вас будет обслуживать:"+name, brand);
        }
        public void MTPLEmployee()
        {
            string name = ("Марк");
            Console.WriteLine("Ваш помощник в получении/замене полиса ОСАГО//Погашении штрафов:"+name);
        }
        public void CarWasher()
        {
            string name = ("Иван");
            Console.WriteLine("Вашу машину помоет:"+name);
        }
        public void VehicleInspectioner()
        {
            string name = ("Нелли");
            string brand = ("Любая марка машины");
            Console.WriteLine("Техосмотр будет проводить:"+name,brand);
        }
    }
}
