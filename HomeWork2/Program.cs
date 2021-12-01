using System;
using static System.Console;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fullName = "Иванов Петр Петрович";
            int  age = 23;
            string email = "PetrPetrovich@gmail.com";
            int programmingPoints = 4;
            int mathPoints = 5;
            int phisicPoints = 4;

            WriteLine($" ФИО: {fullName}\n Возраст: {age}\n Email: {email}\n " +
                $"Прогрммирование: {programmingPoints}\n Математика: {mathPoints}\n Физика: {phisicPoints} ");
           
            ReadKey();
            double midPoint = (programmingPoints + mathPoints + phisicPoints) / 3d;
            WriteLine($"Средний балл = {midPoint}");
        }
    }
}
