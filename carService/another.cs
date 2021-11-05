using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carService
{
    class Another
    {
        private string mtpl;
        private string vehicleInspection;
        private string paymentOfFines;
        private string carWash;
        public string MTPL
        {
            get
            {
                return mtpl;
            }
            private set { }
        }
        public string VehicleInspection
        {
            get
            {
                return vehicleInspection;
            }
            private set { }
        }
        public string PaymentOfFines
        {
            get
            {
                return paymentOfFines;
            }
            private set { }
        }
        public string CarWash
        {
            get
            {
                return carWash;
            }
            private set { }
        }
        Employees employees = new Employees();
        public void MTPLCard()
        {
            Console.WriteLine("Нужна ли вам замена/получение полиса ОСАГО? (да/нет)");
            mtpl = Console.ReadLine().ToLower();
            while (!mtpl.Equals("да") && !mtpl.Equals("нет"))
            {
                Console.WriteLine("Повторите ввод!");
                mtpl = Console.ReadLine().ToLower();
            }
            if (mtpl.Equals("да"))
            {
                Console.WriteLine("Ваш запрос принят!");
                employees.MTPLEmployee();
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
        public void VehicleInsp()
        {
            Console.WriteLine("Нужен ли Вам техосмотр? (да/нет)");
            vehicleInspection = Console.ReadLine().ToLower();
            while (!vehicleInspection.Equals("да") && !vehicleInspection.Equals("нет"))
            {
                Console.WriteLine("Повторите ввод!");
                vehicleInspection = Console.ReadLine().ToLower();
            }
            if (vehicleInspection.Equals("да"))
            {
                Console.WriteLine("Техосмотр будет проведен!");
                employees.VehicleInspectioner();
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
        public void PaymentOfFine()
        {
            Console.WriteLine("Будете ли Вы оплачивать штрафы? (да/нет)");
            paymentOfFines = Console.ReadLine().ToLower();
            while (!paymentOfFines.Equals("да") && !paymentOfFines.Equals("нет"))
            {
                Console.WriteLine("Повторите ввод!");
                paymentOfFines = Console.ReadLine().ToLower();
            }
            if (paymentOfFines.Equals("да"))
            {
                Console.WriteLine("Ваш штраф оплачен!Поздравляем");
                employees.MTPLEmployee();
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
        public void AutoWash()
        {
            Console.WriteLine("Нужна ли Вам мойка авто? (да/нет)");
            carWash = Console.ReadLine().ToLower();
            while (!carWash.Equals("да") && !carWash.Equals("нет"))
            {
                Console.WriteLine("Повторите ввод!");
                carWash = Console.ReadLine().ToLower();
            }
            if (carWash.Equals("да"))
            {
                Console.WriteLine("Ваш запрос принят!");
                employees.CarWasher();
            }
            else
            {
                Console.WriteLine(" ");
            }
        }
    }
}
