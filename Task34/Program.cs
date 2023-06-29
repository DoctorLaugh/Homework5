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
int EvenNum(int[] array)
{
    int num = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) num = num + 1;
    }
    return num;
}
Console.Clear();
Console.WriteLine("Введите размер массива");
int Size = int.Parse(Console.ReadLine());
int MinValue = 100;
int MaxValue = 999;
int[] Array = RandomArray(Size, MinValue, MaxValue);
for (int i = 0; i < Array.Length; i++)
{
    Console.Write($"{Array[i]} ");
}
Console.WriteLine();
int Num = EvenNum(Array);
Console.WriteLine($"Количество чётных чисел в массиве - {Num}");