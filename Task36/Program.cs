int[] RandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}
int OddSum(int[] array)
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 1) sum = sum + array[i];
    }
    return sum;
}
Console.Clear();
Console.WriteLine("Введите размер массива");
int Size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите начальный диапазон массива");
int MinValue = int.Parse(Console.ReadLine());
Console.WriteLine("Введите конечный диапазон массива");
int MaxValue = int.Parse(Console.ReadLine());
int[] Array = RandomArray(Size, MinValue, MaxValue);
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
Console.Write($"Сумма элементов на нечётных позициях - {OddSum(Array)}");