using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace programm7
{
        public enum AccountType { Actual, Savings };
        class BankAccount
        {
            private long number;
            private decimal balance;
            private AccountType accountType;
            private static long uniqNum;

            public void FillIn(long number, decimal balance)
            {
                this.number = number;
                this.balance = balance;
            }
            public static long UniqNumber()
            {
                return uniqNum++;
            }
            public AccountType Type()
            {
                return accountType;
            }
            public decimal PutMoney(decimal summa)
            {
                balance += summa;
                return balance;
            }
            public bool WithdrawMoney(decimal summa)
            {
                bool examination = (balance >= summa);
                if (examination)
                {
                    balance -= summa;
                }
                return examination;
            }
        public void PrintValues()
            {
            Console.WriteLine("Account number" +number);
            Console.WriteLine("Account balance" +balance);
            Console.WriteLine("Account type" +accountType);
            }
        }
    }
