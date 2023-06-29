double[] RandomArray(int size, int minValue, int maxValue)
{
    double[] array = new double[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1) + Math.Round(rnd.NextDouble(), 2);
    }
    return array;
}
double MinMaxSum(double[] array)
{
    double nummin = 0;
    double nummax = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < nummin) nummin = array[i];
        if (array[i] > nummax)  nummax = array[i];
    }
    double minamxsum = nummin + nummax;
    return minamxsum;
}
Console.Clear();
Console.WriteLine("Введите размер массива");
int Size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальный диапазон массива");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечный диапазон массива");
int MaxValue = int.Parse(Console.ReadLine());
double[] Array = RandomArray(Size, MinValue, MaxValue);
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
Console.Write($"Сумма максимального и минимального элементов массива: {Math.Round(MinMaxSum(Array), 2)}");