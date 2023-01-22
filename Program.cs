// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.

Console.Clear();
int[,] matrix = new int[, ]{{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

Console.WriteLine("Укажите номер искомой строки, начиная с 0");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Укажите номер нужного столбца, начиная с 0");
int cols = Convert.ToInt32(Console.ReadLine());

if (rows < 0 || rows > 3 || cols < 0 || cols > 4)
{
    Console.WriteLine($"Такого элемента нет.");
}

else
{
    Console.WriteLine($"В строке {rows}, в колонке {cols} записано значение {matrix[rows, cols]}");
}

