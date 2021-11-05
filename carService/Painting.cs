using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace carService
{
    class Painting
    {
        public void CarPainting()
        {
            Console.WriteLine("В какой цвет нужно покрасить машину? черный/красный/синий");
            string answer = Console.ReadLine().ToLower();
            while (!answer.Equals("красный") && !answer.Equals("черный") && answer.Equals("синий"))
            {
                Console.WriteLine("Такого цвета не имеется! Выберите из предложенных");
                answer = Console.ReadLine().ToLower();
            }
            if (answer.Equals("красный"))
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Thread.Sleep(3000);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Ваша машина была окрашена!");
            }
            else if (answer.Equals("черный"))
            {
                Thread.Sleep(3000);
                Console.Clear();
                Console.WriteLine("Ваша машина была окрашена!");
            }
            else if (answer.Equals("синий"))
            {
                Console.BackgroundColor = ConsoleColor.Blue;
                Thread.Sleep(3000);
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.WriteLine("Ваша машина была окрашена!");
            }
        }
    }
}
