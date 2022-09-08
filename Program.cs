// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// Console.Write("Введи число М (количество чисел): ");
// int numberM = int.Parse(Console.ReadLine());
// int[] array = new int[numberM];

// InputNumbers(numberM);

// void InputNumbers(int numberM)
// {
//     for (int i = 0; i < numberM; i++)
//     {
//         Console.Write($"Введи {i + 1} число: ");
//         array[i] = int.Parse(Console.ReadLine());
//     }
// }

// int Сounting(int[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0) count += 1;
//     }
//     return count;
// }

// Console.WriteLine($"Введено чисел больше 0: {Сounting(array)} ");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] data = new double[2, 2];
double[] InterPoint = new double[2];

InputData();
OutputRes(data);

void InputData()
{
    for (int i = 0; i < data.GetLength(0); i++)
    {
        Console.WriteLine($"Введите коэффициенты {i + 1}-го уравнения (y = k{i + 1} * x + b{i + 1}): ");

        for (int j = 0; j < data.GetLength(1); j++)
        {
            if (j == 0)
            {
                Console.Write($"Введите коэффициент k{i + 1}: ");
            }
            else
            {
                Console.Write($"Введите коэффициент b{i + 1}: ");
            }
            data[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }
}

double[] Solution(double[,] coeff)
{
    InterPoint[0] = (coeff[1, 1] - coeff[0, 1]) / (coeff[0, 0] - coeff[1, 0]);
    InterPoint[1] = InterPoint[0] * coeff[0, 0] + coeff[0, 1];
    return InterPoint;
}

void OutputRes(double[,] coeff)
{
    if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] == coeff[1, 1])
    {
        Console.Write($"Прямые совпадают");
    }
    else
    {
        if (coeff[0, 0] == coeff[1, 0] && coeff[0, 1] != coeff[1, 1])
        {
            Console.Write($"Прямые параллельны");
        }
        else
        {
            Solution(coeff);
            Console.Write($"Точка пересечения прямых: ({InterPoint[0]}, {InterPoint[1]})");
        }
    }
}