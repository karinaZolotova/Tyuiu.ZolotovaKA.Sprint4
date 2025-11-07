using Tyuiu.ZolotovaKA.Sprint4.Task5.V8.Lib;
DataService ds = new DataService();
Console.Title = "Спринт #4| Выполнила: Золотова К. А. | ИCПБ-24-1";
Console.WriteLine("****************************************************");
Console.WriteLine("* Спринт #4                                        *");
Console.WriteLine("*Тема:Двумерные массивы(Генератор случайных чисел) *");
Console.WriteLine("* Задание #5                                       *");
Console.WriteLine("* Вариант #8                                       *");
Console.WriteLine("* Выполнила: Золотова К. А. | ИCПБ-24-1            *");
Console.WriteLine("****************************************************");
Console.WriteLine("* УСЛОВИЕ:                                         *");
Console.WriteLine("*Дан двумерный целочисленный массив 5 на5 элементов*");
Console.WriteLine("*заполненный случайными значениями   в диапазоне от*");
Console.WriteLine("*от -3 до 4. Заменить отрицательные элементы на 0. *");
Console.WriteLine("*                                                  *");
Console.WriteLine("*                                                  *");
Console.WriteLine("****************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                 *");
Console.WriteLine("****************************************************");
Random rnd = new Random();
Console.WriteLine("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество Столбцов в массиве: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] mtrx = new int[rows, columns];
Console.WriteLine("****************************************************");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        mtrx[i, j] = rnd.Next(-3, 4);
    }
}

Console.WriteLine("\nМассив:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{mtrx[i, j]} \t");
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("****************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                       *");
Console.WriteLine("****************************************************");
int[,] res = ds.Calculate(mtrx);

Console.WriteLine("Количество нулевых элементов = " + res);
Console.ReadKey();