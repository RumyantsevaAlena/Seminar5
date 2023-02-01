// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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

int[] arr = FullArrayWithRandomNumbers(6, -50, 50);
System.Console.WriteLine("Наш массив: ");
PrintArray(arr);
int sum = 0;

for (int z = 0; z < arr.Length; z+=2)
    sum = sum + arr[z];

    Console.WriteLine($"всего {arr.Length} чисел, сумма элементов на нечётных позициях = {sum}");