// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// int[] GetArrey(int size , int min, int max)
// {
//     int[] arrey = new int[ size ];
//     for (int i = 0; i < size; i++)
//     {      arrey[i] = new Random().Next (100, 1000 );

//     }
//     return arrey;
// }
 
//  int[] newArrey = GetArrey(4, 100, 1000);

// Console.Write($" arrey = [{ String.Join( " ; ", newArrey)}]" );

// int count = 0;

// for (int i = 0; i < newArrey.Length; i++)
// {
//     if (newArrey[i] % 2  == 0)
//     {
//         count ++;
//     }
    
// }
// Console.Write($" =  { count }");

//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

//  int[] GetArrey(int size , int min, int max)
//  {
//     int[] arrey = new int[ size ];
//         for (int i = 0; i < size; i++)
//     {      arrey[i] = new Random().Next (100 );

//    }
//      return arrey;
// }
// int[] newArrey = GetArrey(4 , 0 , 101);

//     Console.Write($" arrey = [{String.Join(";", newArrey)}]");

//     int sum = 0;

//     for (int i = 1; i < newArrey.Length; i+=2)
// {
//     sum += newArrey[i];
// }

// Console.WriteLine($" -> {sum}");

// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] GetArrey(double size , double min , double max)

{
    double[] arrey = new double [(int)size];
    
    for (int i = 0; i < size; i++)
    {
        arrey[i] = Math.Round (new Random().NextDouble(), 2 );
    }
    return arrey;
}

double[] newArrey  = GetArrey (6, -1 , 0 );

Console.Write($"arrey = [{String.Join(" ; " , newArrey)}]");

double max = 0;

double min = 0;

for (int i = 0; i < newArrey.Length ; i++)
{
    if ( newArrey[i] >= max )
    {
        max = newArrey[i];

    }
    else
    {
        min = newArrey[i];
    }
}

double res = (max - min);

    Console.WriteLine($" max= {max},min ={min}> {res} ");