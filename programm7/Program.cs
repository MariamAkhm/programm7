using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm7
{
    class Program
    {
        public static void TestPutMoney(BankAccount acc)
        {
            Console.WriteLine("Введите сумму");
            decimal sum;
            while (!decimal.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Неверный ввод, попробуйте еще раз");
            }
            acc.PutMoney(sum);
        }
        public static void TestWithdrawMoney(BankAccount acc)
        {
            Console.WriteLine("Введите сумму");
            decimal sum;
            while (!decimal.TryParse(Console.ReadLine(), out sum))
            {
                Console.WriteLine("Неверный ввод, попробуйте еще раз");
            }
            if (!acc.WithdrawMoney(sum))
            {
                Console.WriteLine("Невозможно снять данную сумму денег");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Упражнение 7.(1,2,3)");
            bool flag = true;
            int count = 0;
            while (flag)
            {
                Console.WriteLine("Введите операцию");
                string operation = Console.ReadLine().ToLower();
                BankAccount bankAccount = new BankAccount();
                long number = BankAccount.UniqNumber();
                Console.WriteLine("Введите баланс банковского счета:");
                decimal balance;
                while (!decimal.TryParse(Console.ReadLine(), out balance))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                bankAccount.FillIn(number, balance);
                bankAccount.Type();
                if (operation.Equals("положить на счет"))
                {
                    TestPutMoney(bankAccount);
                    bankAccount.PrintValues();
                }
                else if (operation.Equals("снять со счета"))
                {
                    TestWithdrawMoney(bankAccount);
                    bankAccount.PrintValues();
                }
                else
                {
                    bankAccount.PrintValues();
                }
                //bank_account.PrintValues();
                count++;
                if (count == 3)
                {
                    flag = false;
                }
                Console.ReadKey();
            }
            Console.Clear();
            Console.WriteLine("Домашнее задание 7.1");
            bool flag1 = true;
            int count1 = 0;
            while (flag1)
            {
                Building building = new Building();
                int number = Building.UniqNumber();
                Console.WriteLine("Введите высоту здания");
                int height;
                while (!int.TryParse(Console.ReadLine(), out height))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                Console.WriteLine("Введите кол-во этажей в здании");
                int countOfFloors;
                while (!int.TryParse(Console.ReadLine(), out countOfFloors))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                Console.WriteLine("Введите кол-во квартир в здании");
                int countApart;
                while (!int.TryParse(Console.ReadLine(), out countApart))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                Console.WriteLine("Введите кол-во подъездов в здании");
                int countEnter;
                while (!int.TryParse(Console.ReadLine(), out countEnter))
                {
                    Console.WriteLine("Неверный ввод, попробуйте еще раз");
                }
                building.FillIn(number, height, countOfFloors, countApart, countEnter);
                building.PrintValues();
                count++;
                if (count1 == 3)
                {
                    flag1 = false;
                }
            }
            Console.ReadKey();
        }
    }
}
