using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programm7
{
        class Building
        {
            private static int uniqNumber = 1;
            private int number;
            private int height;
            private int countOfFloors;
            private int countOfApartments;
            private int countOfEntrances;
            public void FillIn(int number, int height, int countOfFloors, int countOfApartments, int countOfEntrances)
            {
                this.number = number;
                this.height = height;
                this.countOfFloors = countOfFloors;
                this.countOfApartments = countOfApartments;
                this.countOfEntrances = countOfEntrances;
            }
            public static int UniqNumber()
            {
                return uniqNumber++;
            }
            public double HeightFloor(double height, double countOfFloors)
            {
                double heightOfFloors;
                if (countOfFloors != 0)
                {
                    heightOfFloors = height / countOfFloors;
                }
                else
                {
                    heightOfFloors = height;
                }
                return heightOfFloors;
            }
            public int CountApartmentsInEntrance(int countOfApartments, int countOfEntrances)
            {
                int apartOfEntrances;
                if (countOfEntrances != 0)
                {
                    apartOfEntrances = countOfApartments / countOfEntrances;
                }
                else
                {
                    apartOfEntrances = countOfApartments;
                }
                return apartOfEntrances;
            }
            public int CountApartmentsOnFloor(int countOfApartments, int countOfFloors)
            {
                int apartOfFloors;
                if (countOfFloors != 0)
                {
                    apartOfFloors = countOfApartments / countOfFloors;
                }
                else
                {
                    apartOfFloors = countOfApartments;
                }
                return apartOfFloors;
            }
            public void PrintValues()
            {
                Console.WriteLine("Номер здания"+ number);
                Console.WriteLine("Высота здания"+ height);
                Console.WriteLine("Кол-во этажей в здании"+ countOfFloors);
                Console.WriteLine("Кол-во квартир в здании"+ countOfApartments);
                Console.WriteLine("Кол-во подъездов в здании" +countOfEntrances);
                Console.WriteLine("Высота одного этажа"+ HeightFloor(height, countOfFloors));
                Console.WriteLine("Кол-во квартир в подъезде" +CountApartmentsInEntrance(countOfApartments, countOfEntrances));
                Console.WriteLine("Кол-во квартир на этаже" +CountApartmentsOnFloor(countOfApartments, countOfFloors));
            }
        }
    }
