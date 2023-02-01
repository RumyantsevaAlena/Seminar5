//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] FullArrayWithRandomNumbers(int size, int leftRange, int rightRange)
{
    int[] arr = new int [size];
    Random rand = new Random();
    for (int i=0; i< arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange+1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    System.Console.WriteLine("["+ string.Join (", ", arr)+"]");
}

int[] array = FullArrayWithRandomNumbers(6, 100, 1000);
System.Console.WriteLine("Изначальный массив: ");
PrintArray(array);
int count = 0;

for(int i=0; i<array.Length;i++ )
{
   if (array[i]%2==0)
   count++;
}
System.Console.WriteLine($"{count}");