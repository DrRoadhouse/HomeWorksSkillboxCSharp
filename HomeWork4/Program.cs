    using System;
    using static System.Console;

namespace HomeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            WriteLine("Задание 1");
            WriteLine("Введите количество столбцов: ");
            int col = int.Parse(ReadLine());
            WriteLine("Введите количество строк: ");
            int row = int.Parse(ReadLine());
            int[,] matrix = new int[col,row];
            int matrixCounter = 0;

            for (int i = 0; i < col; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    matrix[i, j] = new Random().Next(0,5);
                    matrixCounter += matrix[i, j];
                    Write($"{matrix[i,j]} ");    
                }
                WriteLine();
            }
            WriteLine($"Сумма всех чисел в матрице = {matrixCounter}");
            WriteLine();
            WriteLine();

            // Task 2
            WriteLine("Задание 2");
            WriteLine("Введите длинну последовательности:");
            int[] usersArray = new  int[int.Parse(ReadLine())];
            int minValue = int.MaxValue;
            for (int i = 0; i < usersArray.Length; i++)
            {   
                WriteLine($"Введите число #{i + 1}");
                usersArray[i] = int.Parse(ReadLine());
                if (usersArray[i] < minValue)
                    minValue = usersArray[i];
            }
            WriteLine($"Минимальное значение {minValue}");
            WriteLine();
            WriteLine();

            // Task 3
            WriteLine("Задание ");
            WriteLine("Введите крайнее число для создания диапазона: ");
             int endNum = int.Parse(ReadLine());
             int goalNum = new Random().Next(0, ++endNum);
             bool isGameOn = true;
             while (isGameOn)
             {
                 WriteLine("Угадайте число: ");
                 var usersChoise = ReadLine();
                 if (usersChoise.Length == 0)
                 {
                     isGameOn = false;
                     WriteLine($"Загаданное число {goalNum}");
                     break;
                 }
                 else
                 {

                     if (int.Parse(usersChoise) == goalNum)
                     {
                          WriteLine($"Вы угадали! Число {usersChoise} верное!");
                             isGameOn = true;
                             break;
                     }
                     else if(int.Parse(usersChoise) > goalNum)
                     {
                           WriteLine($"{usersChoise} больше загаданного");
                             
                     }

                     else 
                     {
                         WriteLine($"{usersChoise} меньше загаданного");
                     }
                     
                 }

             }
        }
    }
}
