
using CSharpCodes;

int[] numbers = { 38, 27, 43, 3, 9, 82, 10 };
int length = numbers.Length;
Console.WriteLine("Antes del Merge Sort: ");
foreach (int item in numbers)
{
    Console.Write(item + " ");
}
Console.WriteLine();

Console.WriteLine("Después del Merge Sort: ");
MergeSortAlgorithm.SortMethod(numbers, 0, length-1);
foreach (int item in numbers)
{
    Console.Write(item + " ");
}
Console.WriteLine();

