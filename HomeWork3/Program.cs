using System;
using static System.Console;
namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        { 
            WriteLine("Введите число:");
            var userNum = int.Parse(ReadLine());
            WriteLine(userNum % 2 == 0 ?  $"{userNum} Четное": $"{userNum} Нечетное");



            WriteLine("Blackjack");
            WriteLine("Сколько у вас карт?");
            short usersCards = short.Parse(ReadLine());
            int sumOfUsersCards = 0;
            short counter = 0;
            while(counter < usersCards)
            {
                counter++;
                WriteLine($"Какая у вас карта под номером {counter} ?") ;
                switch (ReadLine())
                {
                    case "2":
                        sumOfUsersCards += 2;
                        break;
                    case "3":
                        sumOfUsersCards += 3;
                        break;
                    case "4":
                        sumOfUsersCards += 4;
                        break;
                    case "5":
                        sumOfUsersCards += 5;
                        break;
                    case "6":
                        sumOfUsersCards += 6;
                        break;
                    case "7":
                        sumOfUsersCards += 7;
                        break;
                    case "8":
                        sumOfUsersCards += 8;
                        break;
                    case "9":
                        sumOfUsersCards += 9;
                        break;
                    case "10":
                        sumOfUsersCards += 10;
                        break;
                    case "j":
                        sumOfUsersCards += 10;
                        break;
                    case "q":
                        sumOfUsersCards += 10;
                        break;
                    case "k":
                        sumOfUsersCards += 10;
                        break;
                    case "t":
                        sumOfUsersCards += 10;
                        break;
                }

            }
            WriteLine($"У вас карты общим весом: {sumOfUsersCards} ");


            WriteLine("Введите число:");
            int userNum1 = int.Parse(ReadLine());
            int counter1 = 1;
            bool isSimpleNum = true;
            while(counter1 < userNum1)
            {
                counter1++;
                if (userNum1 % counter1 == 0)
                    isSimpleNum = false;
                break;

            }
            WriteLine($"Число {userNum1}  {(isSimpleNum ? "простое" : "сложное")} ");
            }
        }
    }

