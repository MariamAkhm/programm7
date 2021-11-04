using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carService
{
    class Shop
    {
        private string spare;
        public string Spare
        {
            get
            {
                return spare;
            }
            private set { }
        }
        public void CarShop()
        {
            int summ = 0;
            Console.WriteLine("Вам будут предложены товары, если хотите выйти из магазина, напишите выйти");
            spare = Console.ReadLine().ToLower();
            while (!spare.Equals("выйти"))
            {
                Console.WriteLine("Нужны ли вам шины?да/нет");
                spare= Console.ReadLine().ToLower();
                while (!spare.Equals("да") && !spare.Equals("нет"))
                {
                    Console.WriteLine("Повторите ввод!");
                    spare = Console.ReadLine().ToLower();
                }
                if (spare.Equals("да"))
                {
                    summ += 3000;
                    Console.WriteLine("Вы выбрали шины, с вас:" + summ);
                }
                else
                {
                    Console.WriteLine("Может вам пригодиться что-то еще");
                }
                Console.WriteLine("Нужны ли вам свечи?да/нет");
                spare = Console.ReadLine().ToLower();
                while (!spare.Equals("да") && !spare.Equals("нет"))
                {
                    Console.WriteLine("Повторите ввод!");
                    spare = Console.ReadLine().ToLower();
                }
                if (spare.Equals("да"))
                {
                    summ += 1000;
                    Console.WriteLine("Вы выбрали свечи, с вас:" + summ);
                }
                else
                {
                    Console.WriteLine("Может вам пригодиться что-то еще");
                }
                Console.WriteLine("Нужно ли вам сцепление?да/нет");
                spare = Console.ReadLine().ToLower();
                while (!spare.Equals("да") && !spare.Equals("нет"))
                {
                    Console.WriteLine("Повторите ввод!");
                    spare = Console.ReadLine().ToLower();
                }
                if (spare.Equals("да"))
                {
                    summ += 10000;
                    Console.WriteLine("Вы выбрали сцепление, с вас:" + summ);
                }
                else
                {
                    Console.WriteLine("Может вам пригодиться что-то еще");
                }
                Console.WriteLine("Нужно ли вам моторное масло?да/нет");
                spare = Console.ReadLine().ToLower();
                while (!spare.Equals("да") && !spare.Equals("нет"))
                {
                    Console.WriteLine("Повторите ввод!");
                    spare = Console.ReadLine().ToLower();
                }
                if (spare.Equals("да"))
                {
                    summ += 500;
                    Console.WriteLine("Вы выбрали моторное масло, с вас:" + summ+ "Нам больше нечего Вам предложить. Если вы хотите взять шины, моторное масло, сцепление или свечи еще, напишите-да, если нет, напишите-выйти");
                }
                else
                {
                    Console.WriteLine("Нам больше нечего Вам предложить. Если вы хотите взять шины, моторное масло, сцепление или свечи еще, напишите-да, если нет, напишите-выйти");
                }
                spare = Console.ReadLine();
            }
            Console.WriteLine("Вы купили запчастей на сумму:"+summ);
        }
    }
}
